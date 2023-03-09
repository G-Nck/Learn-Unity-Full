using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Events;

namespace Learn
{
    public abstract class FeatureBase
    {
        public List<Type> paramTypes;

        protected abstract bool IsExcutable(params object[] paraList);

        public abstract void Execute(params object[] paramList);

    }


    public class Feature<T0> : FeatureBase
    {
        public Feature()
        {
            paramTypes = new List<Type>
            {
                typeof(T0)
            };
        }

        public void Execute(T0 value)
        {
        }

        public override void Execute(params object[] paramList)
        {
            throw new NotImplementedException();
        }

        protected override bool IsExcutable(params object[] paraList)
        {
            if (paramTypes.Contains(paraList[0].GetType()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




    }
    public class Feature<T0, T1> : FeatureBase
    {
        public Feature()
        {
            paramTypes = new List<Type>(2)
            {
                typeof(T0),
                typeof(T1)
            };


        }

        public override void Execute(params object[] paramList)
        {
            throw new NotImplementedException();
        }

        protected override bool IsExcutable(params object[] paraList)
        {
            if (paramTypes.Contains(paraList[0].GetType()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    public class Feature<T0, T1, T2> : FeatureBase
    {
        public Feature()
        {
            paramTypes = new List<Type>(3)
            {
                typeof(T0),
                typeof(T1),
                typeof(T2)
            };


        }

        public override void Execute(params object[] paramList)
        {
            throw new NotImplementedException();
        }

        protected override bool IsExcutable(params object[] paraList)
        {
            if (paramTypes.Contains(paraList[0].GetType()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

}
