using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrafficLightUpdate : MonoBehaviour
{
    public float delay;
    public Renderer redLight, amberLight, greenLight;

    Color offColor = Color.black;
    float switchTime;

    bool red, amber, green = false;

    void Start ()
    {
        redLight.material.color = offColor;
        amberLight.material.color = offColor;
        greenLight.material.color = offColor;
        switchTime = Time.time + delay;
        red = true;
    }

	void Update ()
    {
        if (Time.time >= switchTime)
        {
            if(red)
            {
                redLight.material.color = Color.red;
                amberLight.material.color = offColor;
                greenLight.material.color = offColor;
                red = false;
                amber = false;
                green = true;
            }
            else if(green)
            {
                redLight.material.color = offColor;
                amberLight.material.color = offColor;
                greenLight.material.color = Color.green;
                red = false;
                amber = true;
                green = false;
            }
            else if (amber)
            {
                redLight.material.color = offColor;
                amberLight.material.color = Color.yellow;
                greenLight.material.color = offColor;
                red = true;
                amber = false;
                green = false;
            }
            switchTime = Time.time + delay;
        }
	}
}

