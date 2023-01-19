using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GyroController : MonoBehaviour
{
    void Start()
    {
        Input.gyro.enabled = true;
    }

    void Update()
    {
        //player.transform.Rotate(0, -Input.gyro.rotationRateUnbiased.y, 0);
    }
}
