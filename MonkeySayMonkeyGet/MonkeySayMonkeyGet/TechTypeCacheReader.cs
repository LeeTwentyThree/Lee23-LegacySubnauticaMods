using System.Collections.Generic;
using System.IO;

namespace MonkeySayMonkeyGet
{
    public class TechTypeCacheReader
    {
        public bool Read()
        {
            var modFolder = Path.GetDirectoryName(Mod.assembly.Location);
            if (InvalidPath(modFolder)) return false;
            var qmodsFolder = Path.GetDirectoryName(modFolder);
            if (InvalidPath(qmodsFolder)) return false;
            var cacheFolder = Path.Combine(qmodsFolder, "Modding Helper", "TechTypeCache");
            if (InvalidPath(cacheFolder)) return false;
            var cacheFile = Path.Combine(cacheFolder, "TechTypeCache.txt");
            if (InvalidPath(cacheFile)) return false;
            var allText = File.ReadAllText(cacheFile);
            if (string.IsNullOrEmpty(allText)) return false;
            entries.Clear();
            var splitted = allText.Split(new char[] { '\n' });
            foreach (var dual in splitted)
            {
                var array = dual.Split(new char[] { ':' });
                if (array.Length != 2)
                {
                    continue;
                }
                var techTypeInt = int.Parse(array[1]);
                var techType = (TechType)techTypeInt;
                entries.Add(new Entry(array[0].ToLower(), techType));
            }
            return entries.Count > 0;
        }

        public readonly List<Entry> entries = new List<Entry>();

        public struct Entry
        {
            public string Name;
            public TechType TechType;

            public Entry(string name, TechType techType)
            {
                Name = name;
                TechType = techType;
            }
        }

        private bool InvalidPath(string path)
        {
            if (!Directory.Exists(path) && !File.Exists(path))
            {
                return true;
            }
            return false;
        }
    }
}
