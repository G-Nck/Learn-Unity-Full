using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Learn
{
    public class ParamSystem : MonoBehaviour
    {
        [SerializeField]
        ParamExtracter paramExtracter;

        UnityEvent<Vector3> example;
        UnityEvent<int> example2;

        void Start()
        {
            example.AddListener(ExtractParam);
            example2.AddListener(ExtractParam);
        }


        public void ExtractParam<T>(T val)
        {
            if(val is Vector3)
            {

            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
