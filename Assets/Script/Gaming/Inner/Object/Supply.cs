using System.Collections;
using Script.Gaming.Inner.Object.Base;
using UnityEngine;

namespace Script.Gaming.Inner.Object
{
    public class Supply : MonoBehaviour
    {
        private int _capacity = 10;
        private bool _canAbsorb;
        private bool _isAbsorbing;

        private void Awake()
        {
            StartCoroutine(Release());
        }

        private void FixedUpdate()
        {
            Fall();
            if (!_canAbsorb) return;

            StartCoroutine(Absorb());
            _canAbsorb = false;
        }

        private IEnumerator Release()
        {
            yield return new WaitForSeconds(20);
            Main.SupplyPool.Release(gameObject);
        }

        private void Fall()
        {
            if (!_isAbsorbing)
            {
                transform.Translate(transform.up * (-1 * Time.deltaTime));
            }
        }

        private IEnumerator Absorb()
        {
            _capacity--;
            Base.Base.BioMass++;
            if (_capacity < 1)
            {
                Hook.GetTarget = false;
                Hook.CanRestore = true;
                Main.SupplyPool.Release(gameObject);
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
            _isAbsorbing = true;
        }
    }
}