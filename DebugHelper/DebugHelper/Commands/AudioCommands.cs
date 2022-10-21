using UnityEngine;
using SMLHelper.V2.Commands;
using System.Collections;
using UWE;

namespace DebugHelper.Commands
{
    public static class AudioCommands
    {
        private const float kDefaultMaxDuration = 10f;

        [ConsoleCommand("playsound")]
        public static void PlaySound(string eventPath, float maxDuration = 0f)
        {
            if (string.IsNullOrEmpty(eventPath))
            {
                ErrorMessage.AddMessage("Correct syntax: 'playsound [eventPath]'.");
                return;
            }

            FMODAsset asset = ScriptableObject.CreateInstance<FMODAsset>();
            asset.path = eventPath;
            asset.id = eventPath;

            var go = new GameObject("SoundEmitter");
            var emitter = go.EnsureComponent<FMOD_CustomEmitter>();
            emitter.followParent = true;
            emitter.transform.position = MainCameraControl.main.transform.position;
            emitter.SetAsset(asset);
            emitter.Play();

            ErrorMessage.AddMessage($"Playing FMOD EventInstance by path '{eventPath}'.");

            if (!CheckEmitterEventValid(emitter))
            {
                ErrorMessage.AddMessage("Warning: This FMOD EventInstance appears to be invalid!");
            }

            if (maxDuration == 0f)
            {
                maxDuration = kDefaultMaxDuration;
                ErrorMessage.AddMessage($"Second parameter not set; this sound will stop playing after {maxDuration} seconds.");
            }
            if (maxDuration >= 0f)
            {
                Object.Destroy(go, maxDuration);
            }
        }

        [ConsoleCommand("loopsound")]
        public static void PlayLoopingSound(string eventPath, float lifetime)
        {
            if (lifetime < 0f)
            {
                ErrorMessage.AddMessage("This sound will not play; lifetime parameter should be a number of seconds greater than 0! Values below zero will destroy the emitter immediately.");
            }
            if (string.IsNullOrEmpty(eventPath))
            {
                ErrorMessage.AddMessage("Correct syntax: 'loopsound [eventPath, lifetime]'.");
                return;
            }

            FMODAsset asset = ScriptableObject.CreateInstance<FMODAsset>();
            asset.path = eventPath;
            asset.id = eventPath;

            var go = new GameObject("SoundEmitter");
            var emitter = go.EnsureComponent<FMOD_CustomLoopingEmitter>();
            emitter.followParent = true;
            emitter.transform.position = MainCameraControl.main.transform.position;
            emitter.SetAsset(asset);
            emitter.Play();

            ErrorMessage.AddMessage($"Playing FMOD EventInstance by path '{eventPath}'.");

            if (!CheckEmitterEventValid(emitter))
            {
                ErrorMessage.AddMessage("Warning: This FMOD EventInstance appears to be invalid!");
            }

            if (lifetime >= 0f)
            {
                Object.Destroy(go, lifetime);
                ErrorMessage.AddMessage($"Emitter will be destroyed in '{lifetime}' seconds.");
            }
        }

        private static bool CheckEmitterEventValid(FMOD_CustomEmitter emitter)
        {
            FMOD.Studio.EventInstance foundEventInstance = default;
            bool valid = true;
            try
            {
                foundEventInstance = emitter.GetEventInstance();
            }
            finally
            {
                if (!foundEventInstance.isValid())
                {
                    valid = false;
                }
            }
            return valid;
        }
    }
}
