using UnityEngine;

namespace Sodhium.Vectors.Utilities
{
    public static class DrawUtils
    {
        public static void DrawCircle(Vector2 center, float radius, LineRenderer lineRenderer, int segments = 100)
        {
            float angleStep = 360f / segments;
            Vector3[] points = new Vector3[segments + 1];
            int i = 0;
            for (; i <= segments; i++)
            {
                float angle = Mathf.Deg2Rad * angleStep * i;
                points[i] = new Vector3(center.x + Mathf.Cos(angle) * radius, center.y + Mathf.Sin(angle) * radius, 0);
            }

            lineRenderer.positionCount = i;
            lineRenderer.SetPositions(points);
        }
    }
}
