using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class CheckScreen : MonoBehaviour
{
    Camera m_MainCamera;

    void Start()
    {
        m_MainCamera = Camera.main;
        m_MainCamera.enabled = true;
    }

    public void CalculateFill(Color[] colors, Color reference, float tolerance)
    {
        Vector3 target = new Vector3 { x = reference.r, y = reference.g, z = reference.b };
        int numHits = 0;
        const float sqrt_3 = 1.73205080757f;
        for (int i = 0; i < colors.Length; i++)
        {
            Vector3 next = new Vector3 { x = colors[i].r, y = colors[i].g, z = colors[i].b };
            float mag = Vector3.Magnitude(target - next) / sqrt_3;
            numHits += mag <= tolerance ? 1 : 0;
        }
        //return (float)numHits / (float)colors.Length; ;
    }



    public void Hello()
    {
        // Make a new texture of the right size and
        // read the camera image into it.
        var tex = new Texture2D(Screen.width, Screen.height);
        tex.ReadPixels(new Rect(0, 0, 128, 128), 0, 0);
        tex.Apply();

        var a = Screen.currentResolution;
        UnityEngine.Debug.Log("hi");
        var test = m_MainCamera.targetTexture;
    }
    
    public float CalculateSimilarity(Color[] colors, Color reference)
    {
        Vector3 target = new Vector3 { x = reference.r, y = reference.g, z = reference.b };
        float accu = 0;
        const float sqrt_3 = 1.73205080757f;
        for (int i = 0; i < colors.Length; i++)
        {
            Vector3 next = new Vector3 { x = colors[i].r, y = colors[i].g, z = colors[i].b };
            accu += Vector3.Magnitude(target - next) / sqrt_3;
        }
        return 1f - ((float)accu / (float)colors.Length);
    }
}
