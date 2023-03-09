using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Learn
{
    public abstract class ParamReciever<T> : MonoBehaviour
    {
        public abstract void Recieve(object input);
        public abstract T Convert(object input);

    }
}
