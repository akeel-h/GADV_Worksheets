using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Projectile
{
    private float speed;
    public Projectile(float initialSpeed)
    {
        speed = initialSpeed;
    }

    public void Fire()
    {
        if (speed > 0)
        {
            Debug.Log($"Firing projectile at speed {speed}");
        }
        else if (speed == 0)
        {
            AutoFire();  
        }
        else
        {
            Debug.Log("Cannot fire: speed too low.");
        }
    }   

    private void AutoFire()
    {
        speed = 100;
        Debug.Log("Speed was zero. AutoFire set speed to 100 and launched!");
    }
}

