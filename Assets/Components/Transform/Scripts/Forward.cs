using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{
    /// <summary>
    /// Z�࿡ ���� ȸ���� ���մϴ�. 
    /// </summary>
    public class Forward : TransformFunction, IExample
    {
        public void Execute()
        {
           var fwd = targetTransform.forward;
        }

    }
}
