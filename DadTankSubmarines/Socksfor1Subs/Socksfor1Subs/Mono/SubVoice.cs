using System.Collections.Generic;
using UnityEngine;

namespace Socksfor1Subs.Mono
{
    public abstract class SubVoice : MonoBehaviour
    {
        [System.Serializable]
        public class VoiceLine
        {
            public string id;
            public string[] multiId;
            public FMODAsset fmodAsset;
            public FMODAsset[] fmodAssets;
            public string subtitleKey;
            public string[] subtitleKeys;
            public float soundDuration;
            public float minDelay;

            private Mode mode;

            public VoiceLine(string id, float soundDuration, float minDelay = 5f)
            {
                this.id = id;
                fmodAsset = Helpers.GetFmodAsset(id);
                subtitleKey = id;
                this.soundDuration = soundDuration;
                this.minDelay = minDelay;
                mode = Mode.Single;
            }

            public VoiceLine(string id, string[] ids, float maxSoundDuration, float minDelay = 5f)
            {
                this.id = id;
                multiId = ids;
                fmodAssets = new FMODAsset[ids.Length];
                for (int i = 0; i < ids.Length; i++)
                {
                    fmodAssets[i] = Helpers.GetFmodAsset(ids[i]);
                }
                subtitleKeys = new string[ids.Length];
                for (int i = 0; i < subtitleKeys.Length; i++)
                {
                    subtitleKeys[i] = ids[i];
                }
                soundDuration = maxSoundDuration;
                this.minDelay = minDelay;
                mode = Mode.Random;
            }

            public float timeLastPlayed = float.MinValue;
            public float timeCanPlayAgain = float.MinValue;

            public void Play()
            {
                if (mode == Mode.Single)
                {
                    PlaySingle();
                }
                else if (mode == Mode.Random)
                {
                    PlayRandom();
                }
            }

            private void PlaySingle()
            {
                Utils.PlayFMODAsset(fmodAsset, Player.main.transform.position);
                timeCanPlayAgain = Time.time + minDelay;
                timeLastPlayed = Time.time;
                if (!string.IsNullOrEmpty(subtitleKey))
                {
                    Subtitles.main.Add(subtitleKey);
                }
            }

            private void PlayRandom()
            {
                int random = Random.Range(0, multiId.Length);
                Utils.PlayFMODAsset(fmodAssets[random], Player.main.transform.position);
                timeCanPlayAgain = Time.time + minDelay;
                timeLastPlayed = Time.time;
                var subtitleKey = subtitleKeys[random];
                if (!string.IsNullOrEmpty(subtitleKey))
                {
                    Subtitles.main.Add(subtitleKey);
                }
            }

            private enum Mode
            {
                Single,
                Random
            }
        }

        public List<VoiceLine> voiceLines;

        private void Start()
        {
            OnInitialize();
        }

        protected abstract void OnInitialize();

        public void InitializeVoiceLines(params VoiceLine[] newVoiceLines)
        {
            voiceLines = new List<VoiceLine>();
            foreach (var line in newVoiceLines)
            {
                voiceLines.Add(line);
            }
        }

        public bool VoiceLinePlaying
        {
            get
            {
                foreach (var voiceLine in voiceLines)
                {
                    if (Time.time < voiceLine.timeLastPlayed + voiceLine.soundDuration)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private VoiceLine GetVoiceLine(string id)
        {
            foreach (var line in voiceLines)
            {
                if (line.id == id)
                {
                    return line;
                }
            }
            return null;
        }

        public bool PlayVoiceLine(string voiceLineId, bool canInterruptSelf = false)
        {
            if (!canInterruptSelf && VoiceLinePlaying)
            {
                return false;
            }
            var line = GetVoiceLine(voiceLineId);
            if (Time.time < line.timeCanPlayAgain)
            {
                return false;
            }
            line.Play();
            return true;
        }
    }
}
