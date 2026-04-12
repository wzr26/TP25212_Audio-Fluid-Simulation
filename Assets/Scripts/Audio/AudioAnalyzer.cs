using UnityEngine;

public class AudioAnalyzer : MonoBehaviour
{
    public AudioSource audioSource;
    public float[] spectrum = new float[256];

    public static float audioValue;

    void Update()
    {
        audioSource.GetSpectrumData(spectrum, 0, FFTWindow.Blackman);

        float sum = 0;

        for (int i = 0; i < spectrum.Length; i++)
        {
            sum += spectrum[i];
        }

        audioValue = sum * 20f;
    }
}
