using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongFade : MonoBehaviour
{
    Material mat;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    void OnMouseDown()
    {
        StartCoroutine(FadeOutPingPong());
    }

    IEnumerator FadeOutPingPong()
    {
        bool fadingOut = true;
        float alpha = 1f;

        while (true)
        {
            Color c = mat.color;
            c.a = alpha;
            mat.color = c;

            yield return new WaitForSeconds(0.05f);

            if (alpha >= 1f)
            {
                alpha -= 0.05f;
                if (alpha <= 0f)
                {
                    alpha = 0f;
                    fadingOut = false;
                }
            }
            else
            {
                alpha += 0.05f;
                if (alpha >= 1f)
                {
                    alpha = 1f;
                    fadingOut = true;
                }
            }
        }
    }

}

