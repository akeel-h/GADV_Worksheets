using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutines : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Infinite());
    }

    IEnumerator Infinite()
    {
        while (true)
        {
            Debug.Log("Now I yield");
            yield return null;
        }
    }
}


