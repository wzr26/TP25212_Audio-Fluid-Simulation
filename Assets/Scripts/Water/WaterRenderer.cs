using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class WaterRenderer : MonoBehaviour
{
    public WaterController water;
    LineRenderer line;

    void Start()
    {
        line = GetComponent<LineRenderer>();
        line.positionCount = water.pointCount;
    }

    void Update()
    {
        for (int i = 0; i < water.pointCount; i++)
        {
            float x = i * water.width / water.pointCount;
            float y = water.points[i].height;

            line.SetPosition(i, new Vector3(x, y, 0));
        }
    }
}
