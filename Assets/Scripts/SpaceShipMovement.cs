using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMovement : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        //transform.Rotate(Vector3.forward, speed * Time.deltaTime, Space.Self);
        float rotX = Input.GetAxis("Mouse X") * speed * Mathf.Deg2Rad;
        //float rotY = Input.GetAxis("Mouse Y") * speed * Mathf.Deg2Rad;

        transform.RotateAround(Vector3.forward, -rotX);
       // transform.RotateAround(Vector3.right, rotY);
    }
}
