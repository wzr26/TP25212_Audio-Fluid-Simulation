using UnityEngine;

public class WaterPoint
{
    public float height;
    public float velocity;

    public float targetHeight;

    public WaterPoint(float h)
    {
        height = h;
        targetHeight = h;
        velocity = 0;
    }

    public void Update(float tension, float damping)
    {
        float force = tension * (targetHeight - height);
        velocity += force;
        velocity *= (1 - damping);
        height += velocity;
    }
}
