using PlasticGui.WorkspaceWindow.QueryViews.Branches;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.YamlDotNet.Core.Tokens;
using UnityEngine;

namespace Learn
{
    public class Vector3Reciever : MonoBehaviour, IParamReciever<Vector3>
    {
        public Vector3 data { get; set; }


    }
}
