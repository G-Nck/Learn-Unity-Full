using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{

    /// <summary>
    /// ���� �ڽ��� ���� ��ȯ�մϴ�.
    /// </summary>
    [AddComponentMenu("Examples/Components/Transform/Hierachy Capacity")]
    public class HierarchyCapacity : TransformFunction, IExample
    {
        private void Start()
        {
            Execute();
        }

        public void Execute()
        {
            int count = targetTransform.hierarchyCapacity;
            Debug.Log(count);
        }

        void meow()
        {
            
        }
    }
}
