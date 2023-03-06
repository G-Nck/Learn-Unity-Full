using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using Unity.Burst;
using Unity.Jobs;
using UnityEngine.Jobs;
using System.Diagnostics;


namespace Learn.Burst
{

    public class DistanceTest : MonoBehaviour
    {

        [BurstCompile]
        public struct DistanceJob : IJobParallelForTransform
        {
            [ReadOnly]
            public Vector3 origin;
            [WriteOnly]
            public NativeArray<float> Output;
            [ReadOnly]
            public float distance;

            public void Execute(int index, TransformAccess transform)
            {
                Output[index] = Vector3.Distance(origin, transform.position);

            }
        }




        Stopwatch Stopwatch = new Stopwatch();
        Transform[] m_Transforms;
        TransformAccessArray m_AccessArray;
        JobHandle currentJob;

        [SerializeField]
        int count;
        List<Vector3> uiPos = new List<Vector3>();
        NativeArray<float> check;

        bool shouldCheck = false;

        private void Start()
        {
            check = new NativeArray<float>(count, Allocator.Persistent);

        }

        void ExecuteTestBurst()
        {
            Stopwatch.Start();

            var job = new DistanceJob
            {
                distance = 3,
                origin = Vector3.zero,
                Output = check
            };

            var jobHandle = job.Schedule(m_AccessArray);
            shouldCheck = true;
            currentJob = jobHandle;

            jobHandle.Complete();
            Stopwatch.Stop();
            UnityEngine.Debug.Log($"Calculated Burst {count} : {Stopwatch.ElapsedMilliseconds} ms");
            Stopwatch.Reset();
        }

        public void Update()
        {
            if (shouldCheck && currentJob.IsCompleted)
            {
                UnityEngine.Debug.Log("Checking");
                for (int i = 0; i < check.Length; i++)
                {
                    if (check[i] > 5)
                    {
                        uiPos.Add(m_Transforms[i].position);
                    }
                }


                shouldCheck = false;

            }

        }


        void ExecuteTestMono()
        {
            Stopwatch.Start();

            for (int i = 0; i < m_AccessArray.length; i++)
            {
                var distance = Vector3.Distance(Vector3.zero, m_AccessArray[i].position);
                check[i] = distance;
            }

            Stopwatch.Stop();

            UnityEngine.Debug.Log($"Calculated Mono {count} : {Stopwatch.ElapsedMilliseconds} ms");
            Stopwatch.Reset();

        }


        public void SetTestEnvironment()
        {
            int destinationCount = count;

            Vector3 range = new Vector3(100, 100, 100);

            List<Transform> transforms = new List<Transform>(destinationCount);

            for (int i = 0; i < destinationCount; i++)
            {
                GameObject gameObject = new GameObject();
                gameObject.transform.position = GetRandomVector(range);
                transforms.Add(gameObject.transform);
            }

            m_Transforms = transforms.ToArray();
            m_AccessArray = new TransformAccessArray(m_Transforms);

        }

        public static Vector3 GetRandomVector(Vector3 range)
        {
            float x = Random.Range(-range.x, range.x);
            float y = Random.Range(-range.y, range.y);
            float z = Random.Range(-range.z, range.z);

            return new Vector3(x, y, z);

        }

        private void OnGUI()
        {
            if (GUILayout.Button("Set Env"))
            {
                SetTestEnvironment();
            }

            if (GUILayout.Button("Execute Burst"))
            {
                ExecuteTestBurst();
            }
            if (GUILayout.Button("Execute Mono"))
            {
                ExecuteTestMono();
            }
        }

        private void OnDrawGizmos()
        {
            foreach (var pos in uiPos)
            {
                Gizmos.DrawSphere(pos, 0.1f);
            }
        }

        private void OnDestroy()
        {
            m_AccessArray.Dispose();
            check.Dispose();
        }

    }

}
