using UnityEngine;
using Sodhium.Vectors.Utilities;

namespace Sodhium.VectorsPlayground.Utilities
{
    public class DistanceConstraint : MonoBehaviour
    {
        public Transform outerCircle;
        public Transform centerCircle;
        public float maxDistance = 1f;

        void Update()
        {
            Vector3 mouseWorldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mouseWorldPos.z = 0;

            outerCircle.position = mouseWorldPos;

            Vector3 toNext = mouseWorldPos - centerCircle.position;

            if (toNext.magnitude > maxDistance)
            {
                centerCircle.position = ConstrainDistance(centerCircle.position, mouseWorldPos, maxDistance);
            }
        }

        Vector3 ConstrainDistance(Vector3 point, Vector3 anchor, float distance)
        {
            return (point - anchor).normalized * distance + anchor;
        }
    }
}