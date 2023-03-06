using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{
    /// <summary>
    /// false로 설정 이후, 값 변동이 있으면 true로 변합니다.
    /// </summary>
    public class HasChanged : TransformFunction, IExample
    {
        [SerializeField]
        bool hasChanged;

        private void Start()
        {
            targetTransform.hasChanged = false;
        }

        private void Update()
        {
            hasChanged = targetTransform.hasChanged;
        }

        public void Execute()
        {
            targetTransform.hasChanged = true;
        }
    }
}
