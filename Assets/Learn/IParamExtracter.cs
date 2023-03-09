using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn
{
    public interface IParamExtracter<T>
    {

        public void Extract(out T value)
        {
            value = default(T);    
        }

    }
}
