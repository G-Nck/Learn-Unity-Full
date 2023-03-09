using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Learn
{
    public class TransformExtracter : MonoBehaviour
    {
        [SerializeField]
        Vector3Reciever reciever;
        [SerializeField]
        TransformReciever recieverTransform;
        [SerializeField]
        object data;

        // Start is called before the first frame update
        void Start()
        {
            IParamReciever<Vector3> reciever2 = reciever;
            reciever2.Recieve(transform.position);


            data = transform.position;
            
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}
