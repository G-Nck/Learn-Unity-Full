using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{
    /// <summary>
    /// false�� ���� ����, �� ������ ������ true�� ���մϴ�.
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
