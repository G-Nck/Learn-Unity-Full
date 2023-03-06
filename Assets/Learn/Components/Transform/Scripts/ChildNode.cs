using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Learn.Component.TransformFeatures
{

    [RequireComponent(typeof(LineRenderer))]
    public class ChildNode : MonoBehaviour
    {
        LineRenderer lineRenderer;

        private void Awake()
        {
            lineRenderer = GetComponent<LineRenderer>();
        }

        void Update()
        {
            VisualizeChildNode();
        }


        void VisualizeChildNode()
        {
            List<Vector3> linePosArray = new List<Vector3>();

            foreach(Transform transform in transform)
            {
                linePosArray.Add(transform.position);
                linePosArray.Add(this.transform.position);
            }

            lineRenderer.SetPositions(linePosArray.ToArray());
            lineRenderer.positionCount = linePosArray.Count;
        }

    }
}
