using GluonGui.Dialog;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn
{
    public interface IParamReciever<T>
    {
        T data { get; set; }

        private bool TryConvert(object input, out T result)
        {
            if(input is T)
            {
                result = (T)input;
                return true;
            }
            else
            {
                result = default(T);
                return false;
            }
        }
        public bool Recieve(object input)
        {
            bool v = TryConvert(input, out var data);
            this.data = data; 
            return v;
        }

    }
}
