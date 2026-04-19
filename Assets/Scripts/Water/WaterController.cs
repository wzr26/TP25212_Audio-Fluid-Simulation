using UnityEngine;

public class WaterController : MonoBehaviour
{
    public int pointCount = 50;
    public float width = 10f;

    public float tension = 0.025f;
    public float damping = 0.025f;
    public float spread = 0.25f;

    public WaterPoint[] points;

    void Start()
    {
        points = new WaterPoint[pointCount];

        for (int i = 0; i < pointCount; i++)
        {
            points[i] = new WaterPoint(0);
        }
    }

    void Update()
    {
        UpdateWater();
    }

    void UpdateWater()
    {
        for (int i = 0; i < points.Length; i++)
        {
            points[i].Update(tension, damping);
        }

        // spread
        for (int i = 0; i < points.Length - 1; i++)
        {
            float delta = spread * (points[i].height - points[i + 1].height);

            points[i].velocity -= delta;
            points[i + 1].velocity += delta;
        }
    }

    public void Splash(int index, float force)
    {
        if (index >= 0 && index < points.Length)
        {
            points[index].velocity += force;
        }
    }
}
