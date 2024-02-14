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

        private void Start()
        {
            StartCoroutine(Stretch());
        }

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
            _canRotate = true;
        }

        public void Shot(bool shooting)
        {
            if (!shooting) return;

            Stop = false;
            _canRotate = false;
            _canStretch = true;
            hookRoot.transform.Rotate(Vector3.zero);
        }


        private IEnumerator Stretch()
        {
            if (_canStretch)
            {
                var temp = hookRoot.transform.localScale;
                temp.x += 0.04f;
                hookRoot.transform.localScale = temp;
            }

            yield return new WaitForSeconds(0.02f);
            StartCoroutine(Stretch());
        }
    }
}