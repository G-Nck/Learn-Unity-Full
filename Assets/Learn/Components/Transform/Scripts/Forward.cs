using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{
    /// <summary>
    /// Z축에 현재 회전을 곱합니다. 
    /// </summary>
    public class Forward : TransformFunction, IExample
    {
        public void Execute()
        {
           var fwd = targetTransform.forward;
        }

    }
}
