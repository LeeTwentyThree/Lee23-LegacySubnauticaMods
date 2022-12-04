using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RandomEvents
{
    public class RandomEventOnDrop : MonoBehaviour
    {
        //unity sendmessage thing
        public void OnDrop()
        {
            GameObject obj = new GameObject();
            obj.EnsureComponent(Utils.GetRandomEvent(""));
            Destroy(gameObject);
        }
    }
}
