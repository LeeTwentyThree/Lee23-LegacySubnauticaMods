using UnityEngine;
using SMLHelper.V2.Commands;
using System.Collections;
using UWE;

namespace DebugHelper.Commands
{
    public static class PrefabCommands
    {
        private static GameObject signPrefab;

        [ConsoleCommand("spawnp")]
        public static void SpawnByPath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                ErrorMessage.AddMessage("Correct syntax: 'spawnp [path]'.");
            }
            GameObject prefab = Resources.Load<GameObject>(path);
            if (prefab != null)
            {
                ErrorMessage.AddMessage($"Spawned prefab '{prefab.name}' successfully.");
                Object.Instantiate(prefab, Player.main.transform.position + (Player.main.transform.forward * 5f), Quaternion.identity);
            }
            else
            {
                ErrorMessage.AddMessage($"Failed to load prefab by path '{path}'.");
            }
        }

        [ConsoleCommand("spawnc")]
        public static void SpawnByClassId(string classId)
        {
            if (string.IsNullOrEmpty(classId))
            {
                ErrorMessage.AddMessage("Correct syntax: 'spawnc [ClassId]'.");
            }
            CoroutineHost.StartCoroutine(SpawncCoroutine(classId));
        }

        private static IEnumerator SpawncCoroutine(string classId)
        {
            var prefabRequest = PrefabDatabase.GetPrefabAsync(classId);
            yield return prefabRequest;
            if (prefabRequest.TryGetPrefab(out GameObject prefab))
            {
                ErrorMessage.AddMessage($"Spawned prefab '{prefab.name}' successfully.");
                Utils.CreatePrefab(prefab, 12f, false);
            }
            else
            {
                ErrorMessage.AddMessage($"Failed to load prefab by ClassId '{classId}'.");
            }
        }

        [ConsoleCommand("search")]
        public static void Search(float distance)
        {
            float maxDist = float.MaxValue;
            if (distance >= 0f) maxDist = distance;
            foreach (PrefabIdentifier prefabIdentifier in Object.FindObjectsOfType<PrefabIdentifier>())
            {
                var dist = Vector3.Distance(SNCameraRoot.main.transform.position, prefabIdentifier.transform.position);
                if (dist < maxDist)
                {
                    var techType = CraftData.GetTechType(prefabIdentifier.gameObject);
                    if (techType == TechType.None)
                    {
                        ErrorMessage.AddMessage($"Found object '{prefabIdentifier.gameObject.name}' ({(int)dist}m away)");
                    }
                    else
                    {
                        ErrorMessage.AddMessage($"Found object '{prefabIdentifier.gameObject.name}' with TechType '{techType}' ({(int)dist}m away)");
                    }
                }
            }
        }

        [ConsoleCommand("entgal")]
        public static void EntityGallery()
        {
            CoroutineHost.StartCoroutine(EntgalCoroutine());
        }

        private static IEnumerator EntgalCoroutine()
        {
            if (signPrefab == null)
            {
                IPrefabRequest request = PrefabDatabase.GetPrefabAsync("19524fc9-f1cc-4bc9-9404-94aaaf3e81a0");
                yield return request;
                request.TryGetPrefab(out signPrefab);
            }

            Vector3 offset = new Vector3(-1250f, -10f, -1250f);
            Player.main.SetPosition(offset);
            GameObject[] objects = Resources.LoadAll<GameObject>("WorldEntities");
            const float verticalSpacing = 10f;
            const float horizontalSpacing = 30f;
            Vector3 vertical = Vector3.forward;
            Vector3 horizontal = Vector3.right;
            int verticalOffset = 0;
            int horizontalIterations = 0;
            for (int i = 0; i < objects.Length; i++)
            {
                SpawnEntgalEntity(objects[i], offset + (vertical * (verticalSpacing * verticalOffset)) + (horizontal * (horizontalSpacing * horizontalIterations)));
                if (verticalOffset < 400)
                {
                    verticalOffset++;
                }
                else
                {
                    verticalOffset = 0;
                    horizontalIterations++;
                }
                yield return null;
            }
            ErrorMessage.AddMessage("Successfully spawned " + objects.Length.ToString() + " entities.");
        }

        static void SpawnEntgalEntity(GameObject prefab, Vector3 position)
        {
            if (prefab.name == "Cold") return;
            GameObject spawnedPrefab = Object.Instantiate(prefab, position, Quaternion.identity);
            Rigidbody rb = spawnedPrefab.GetComponent<Rigidbody>();
            if (rb != null) rb.isKinematic = true;
            GameObject signGameObject = Object.Instantiate(signPrefab, position + (Vector3.right * 2f), Quaternion.LookRotation(Vector3.right));
            GenericSign sign = signGameObject.GetComponent<GenericSign>();
            sign.key = prefab.name;
            sign.UpdateCanvas();
        }
    }
}
