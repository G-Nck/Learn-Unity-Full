using Codice.CM.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

namespace Learn
{
    public class TransformReciever : MonoBehaviour
    {

        Feature<int, int> meow = new Feature<int, int>();
        Feature<int, int, float> meow2 = new Feature<int, int, float>();


        private void Start()
        {
            /*           meow.paramTypes.Sort();
                       meow2.paramTypes.Sort();*/
            meow.paramTypes.Sort((a, b) => a.GetType().FullName.CompareTo(b.GetType().FullName));
            meow2.paramTypes.Sort((a, b) => a.GetType().FullName.CompareTo(b.GetType().FullName));
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var type in meow.paramTypes)
            {
                stringBuilder.AppendLine(type.FullName);

            }
            Debug.Log(stringBuilder.ToString());

            stringBuilder.Clear();
            foreach (var type in meow2.paramTypes)
            {
                stringBuilder.AppendLine(type.FullName);
            }
            Debug.Log(stringBuilder.ToString());


        }

    }
}
