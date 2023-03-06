using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{

    /// <summary>
    /// 직속 자식의 수를 반환합니다.
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
