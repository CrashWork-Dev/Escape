using System.Collections;
using UnityEngine;

namespace Script.Inner.Object.Base
{
    public class Hook : MonoBehaviour
    {
        [SerializeField] private GameObject hookRoot;
        private bool _canRotate = true;

        private bool _canStretch;

        //todo 勾到吸取完后 GetTarget = false;
        public static bool GetTarget;
        public static bool Stop;
        public static bool CanRestore;

        private void Update()
        {
            HookRotate(_canRotate);
            StopShot();
            Restore();
        }

        private void HookRotate(bool rotate)
        {
            if (rotate)
            {
                hookRoot.transform.Rotate(Vector3.forward, 30 * Time.deltaTime);
            }
        }


        private void Restore()
        {
            if (!CanRestore) return;
            var temp = hookRoot.transform.localScale;
            temp.x = 1;
            hookRoot.transform.localScale = temp;
            CanRestore = false;
        }

        private void StopShot()
        {
            if (!Stop) return;
            _canStretch = false;
            //StopAllCoroutines();
            _canRotate = true;
        }

        public void Shot()
        {
            Stop = false;
            _canRotate = false;
            if (!_canStretch)
            {
                StartCoroutine(Stretch());
            }
            _canStretch = true;
            hookRoot.transform.Rotate(Vector3.zero);
        }


        private IEnumerator Stretch()
        {
            var temp = hookRoot.transform.localScale;
            temp.x += 0.04f;
            hookRoot.transform.localScale = temp;

            yield return new WaitForSeconds(0.02f);
            if(!_canStretch) yield break;
            StartCoroutine(Stretch());
        }
    }
}