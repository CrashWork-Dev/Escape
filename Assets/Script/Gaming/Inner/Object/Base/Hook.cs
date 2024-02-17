using System.Collections;
using UnityEngine;

namespace Script.Gaming.Inner.Object.Base
{
    public class Hook : MonoBehaviour
    {
        [SerializeField] private GameObject hookRoot;
        private bool _canRotate = true;
        private BoxCollider2D _hitBox;
        private static bool _canStretch;

        public static bool CanRestore;
        public static bool GetTarget;

        private void Start()
        {
            _hitBox = GetComponent<BoxCollider2D>();
            _hitBox.enabled = false;
        }

        private void Update()
        {
            HookRotate(_canRotate);
            Absorb();
            Restore();
        }

        private void HookRotate(bool rotate)
        {
            if (rotate)
            {
                hookRoot.transform.Rotate(Vector3.forward, 30 * Time.deltaTime);
            }
            else
            {
                hookRoot.transform.Rotate(Vector3.zero);
            }
        }

        private void Absorb()
        {
            if (GetTarget)
            {
                Stop();
            }
        }

        private void Restore()
        {
            if (!CanRestore) return;
            Stop();
            var temp = hookRoot.transform.localScale;
            temp.x = 1;
            hookRoot.transform.localScale = temp;
            CanRestore = false;
            _canRotate = true;
        }


        private void Stop()
        {
            _canStretch = false;
            _hitBox.enabled = false;
        }

        public void Shot()
        {
            _canRotate = false;
            if (!_canStretch)
            {
                StartCoroutine(Stretch());
            }

            _canStretch = true;
            _hitBox.enabled = true;
        }


        private IEnumerator Stretch()
        {
            var temp = hookRoot.transform.localScale;
            temp.x += 0.04f;
            hookRoot.transform.localScale = temp;

            yield return new WaitForSeconds(0.02f);
            if (!_canStretch) yield break;
            StartCoroutine(Stretch());
        }
    }
}