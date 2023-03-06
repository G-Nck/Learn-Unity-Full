using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{

    /// <summary>
    /// 쿼터니언 각을 euler 각으로 변환하여 반환합니다.
    /// </summary>
    public class EulerAngles : TransformFunction, IExample
    {

        public void Execute()
        {
            var angles = targetTransform.eulerAngles;
        }
    }
}
