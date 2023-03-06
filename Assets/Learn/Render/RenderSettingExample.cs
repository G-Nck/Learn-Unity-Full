using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn
{
    public class RenderSettingExample : MonoBehaviour
    {
        [SerializeField]
        Material skybox;

        // Start is called before the first frame update
        void Start()
        {
            RenderSettings.skybox = skybox;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
