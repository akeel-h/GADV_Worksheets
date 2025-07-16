using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightCoroutine : MonoBehaviour
{
    public float delay;
    public Renderer redLight, amberLight, greenLight;

    Color offColor = Color.black;

    void Start()
    {
        StartCoroutine(RunLights());
    }

    IEnumerator RunLights()
    {
        while (true)
        {
            Red();
            yield return new WaitForSeconds(delay);
            Green();
            yield return new WaitForSeconds(delay);
            Amber();
            yield return new WaitForSeconds(delay);
        }
    }

    void ResetLights()
    {
        redLight.material.color = offColor;
        amberLight.material.color = offColor;
        greenLight.material.color = offColor;
    }

    void Red()
    {
        ResetLights();
        redLight.material.color = Color.red;
    }

    void Green()
    {
        ResetLights();
        greenLight.material.color = Color.green;

    }
    void Amber()
    {
        ResetLights();
        amberLight.material.color = Color.yellow;
    }

}

