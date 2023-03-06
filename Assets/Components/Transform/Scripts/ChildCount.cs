using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{

    /// <summary>
    /// ���� �ڽ��� ���� ��ȯ�մϴ�.
    /// </summary>
    [AddComponentMenu("Examples/Components/Transform/Child Count")]
    public class ChildCount : TransformFunction, IExample
    {
        public void Execute()
        {
            int count = targetTransform.transform.childCount;
        }
    }
}
