using Script.Gaming.Inner.Object.Base;
using UnityEngine;

namespace Script.Gaming.Inner.Object
{
    public class Edge : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.tag.Equals("Hook")) return;
            Hook.CanRestore = true;
        }
    }
}