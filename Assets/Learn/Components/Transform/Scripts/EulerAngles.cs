using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Learn.Component.TransformFeatures
{

    /// <summary>
    /// 쿼터니언 각을 euler 각으로 변환하여 반환합니다.
    /// </summary>
    public class EulerAngles : MonoBehaviour, IExample
    {
        [SerializeField]
        UnityEvent<Vector3> meow;
        [SerializeField]
        TransformFunction transformFunction;

        public void Execute()
        {
            var angles = transformFunction.TargetTransform.eulerAngles;
            meow.Invoke(angles);
            ParamExtracter paramExtracter = new ParamExtracter();
            paramExtracter.ExtractParam(angles);
        }
    }
}
