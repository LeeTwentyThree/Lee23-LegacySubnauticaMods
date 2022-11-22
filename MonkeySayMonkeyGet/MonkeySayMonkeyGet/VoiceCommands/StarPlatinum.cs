using MonkeySayMonkeyGet.Mono.StarPlatinum;
using UnityEngine;

namespace MonkeySayMonkeyGet.VoiceCommands
{
    public class StarPlatinum : VoiceCommandBase
    {
        public override bool AllowPartialInput => true;

        public override Priority Priority => Priority.Low;

        protected override bool IsValid(SpeechInput input)
        {
            if (StarPlatinumActivated)
            {
                if (PhraseManager.ContainsPhrase(input, PhraseManager.Cancel))
                {
                    return true;
                }
            }
            return PhraseManager.ContainsPhrase(input, PhraseManager.StarPlatinum);
        }

        protected override void Perform(SpeechInput input)
        {
            timeLastActivated = Time.time;
            if (!StarPlatinumActivated)
            {
                _instance = StarPlatinumInstance.CreateInstance();
            }
            _instance.MoveToPlayer();
            _instance.CancelAllTasks();
        }

        public override float MinimumDelay => 3f;

        public static float timeLastActivated = -999f;

        public static readonly float duration = 60f;

        public static bool StarPlatinumActivated
        {
            get
            {
                return Time.time < timeLastActivated + duration && Instance != null;
            }
        }

        private static StarPlatinumInstance _instance;

        public static StarPlatinumInstance Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}