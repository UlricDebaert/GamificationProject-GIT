using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UD_MobileSensorTesting : MonoBehaviour
{
    //Test Accelerometer
    /* 
    float speed = 1.0f;

    void Update()
    {
        Vector3 dir = Vector3.zero;

        // we assume that device is held parallel to the ground
        // and Home button is in the right hand

        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
        dir.x = -Input.acceleration.y;
        dir.y = Input.acceleration.x;

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir *= Time.deltaTime;

        // Move object
        transform.Translate(dir * speed);
    }*/


    //Test LinearAcc
    /*
    public float linearAccGraduate;

    private void Start()
    {
        if(LinearAccelerationSensor.current != null)
        {
            InputSystem.EnableDevice(LinearAccelerationSensor.current);
        }
    }

    private void Update()
    {
        if(LinearAccelerationSensor.current != null)
        {
            linearAccGraduate = LinearAccelerationSensor.current.acceleration.ReadValue().x;
            print("sensor is not null");
        }
        else
        {
            print("sensor is null");
        }
        //print(LinearAccelerationSensor.current.acceleration.ReadValue());
    }
    */


    //Test gyro.userAcceleration
    
    public Vector3 forceVec;
    Rigidbody2D rb;

    public float accOnX;

    void Start()
    {
        Input.gyro.enabled = true;
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // Apply forces to an object to match the side-to-side acceleration
        // the user is giving to the device.
        rb.AddForce(Input.gyro.userAcceleration.x * forceVec);

        accOnX = Input.gyro.userAcceleration.x;
    }
}
