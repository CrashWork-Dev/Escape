using System.Collections;
using Script.Inner.Object.Base;
using UnityEngine;

namespace Script.Inner.Object
{
    public class Supply : MonoBehaviour
    {
        private int _capacity = 10;
        private bool _canAbsorb;
        private bool _isAbsorbing;

        private void FixedUpdate()
        {
            if (!_canAbsorb) return;
            StartCoroutine(Absorb());
            _canAbsorb = false;
        }

        private IEnumerator Absorb()
        {
            _capacity--;
            Base.Base.BioMass++;
            if (_capacity < 1)
            {
                Hook.GetTarget = false;
                Hook.CanRestore = true;
                //Main.SupplyPool.Release(gameObject);
                Destroy(gameObject);
                yield break;
            }

            yield return new WaitForSeconds(0.5f);
            StartCoroutine(Absorb());
        }

        private void OnTriggerEnter2D(Collider2D other)
        {
            if (!other.gameObject.tag.Equals("Hook")) return;
            Hook.GetTarget = true;
            _canAbsorb = true;
        }
    }
}