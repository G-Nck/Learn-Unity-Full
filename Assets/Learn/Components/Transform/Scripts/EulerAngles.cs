using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{

    /// <summary>
    /// ���ʹϾ� ���� euler ������ ��ȯ�Ͽ� ��ȯ�մϴ�.
    /// </summary>
    public class EulerAngles : TransformFunction, IExample
    {

        public void Execute()
        {
            var angles = targetTransform.eulerAngles;
        }
    }
}
