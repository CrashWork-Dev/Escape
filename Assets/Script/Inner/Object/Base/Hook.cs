using System;
using UnityEngine;

namespace Script.Inner.Object.Base
{
    public class Hook : MonoBehaviour
    {
        private void Update()
        {
            transform.Rotate(Vector3.forward,30*Time.deltaTime);
        }
    }
}