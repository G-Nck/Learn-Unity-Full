using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Learn.Component.TransformFeatures
{

    /// <summary>
    /// ���ʹϾ� ���� euler ������ ��ȯ�Ͽ� ��ȯ�մϴ�.
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
