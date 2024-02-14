using Script.Inner.Object.Base;
using UnityEngine;

namespace Script.Inner.Object
{
    public class Edge : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag.Equals("Hook"))
            {
                Hook.Stop = true;
                Hook.CanRestore = true;
            }
        }
    }
}