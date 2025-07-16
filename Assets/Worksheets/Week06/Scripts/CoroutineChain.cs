using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineChain : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Sequence());
    }

    IEnumerator Sequence()
    {
        yield return FlashRed();
        yield return MoveUp();
        Debug.Log("Sequence complete!");
    }

    IEnumerator FlashRed()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Flashing red...");
            yield return new WaitForSeconds(0.2f);
        }
    }

    IEnumerator MoveUp()
    {
        while (true)
        {
            transform.position += Vector3.up * 0.1f;
            yield return new WaitForSeconds(0.5f);
        }
    }
}

