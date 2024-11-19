using UnityEngine;
using Sodhium.Vectors.Utilities;

namespace Sodhium.VectorsPlayground.Utilities
{
    [RequireComponent(typeof(LineRenderer))]
    public class CircleDrawer : MonoBehaviour
    {
        public float radius = 1f;
        public int segments = 100;
        public Color lineColor = Color.black;
        public float x = 0;
        public float y = 0;

        private LineRenderer lineRenderer;

        void Start()
        {
            lineRenderer = GetComponent<LineRenderer>();
            lineRenderer.positionCount = segments + 1;
            lineRenderer.useWorldSpace = false;
            lineRenderer.loop = true;
            lineRenderer.startColor = lineColor;
            lineRenderer.endColor = lineColor;
            lineRenderer.widthMultiplier = 0.05f;

            DrawCircleShape();
        }

        public void DrawCircleShape()
        {
            Vector2 center = new Vector2(x, y);
            DrawUtils.DrawCircle(center, radius, lineRenderer, segments);
        }
    }
}