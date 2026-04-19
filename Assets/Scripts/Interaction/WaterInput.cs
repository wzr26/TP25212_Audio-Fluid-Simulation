using UnityEngine;

public class WaterInput : MonoBehaviour
{
    public WaterController water;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int index = Random.Range(0, water.pointCount);
            water.Splash(index, 0.5f);
        }
    }
}
