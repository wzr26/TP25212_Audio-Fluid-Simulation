using UnityEngine;

public class AudioToWater : MonoBehaviour
{
    public WaterController water;

    void Update()
    {
        float value = AudioAnalyzer.audioValue;

        if (value > 0.01f)
        {
            int index = Random.Range(0, water.pointCount);
            water.Splash(index, value);
        }
    }
}
