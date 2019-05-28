using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    public static float speed = 10f;

    void Update()
    {
        transform.Rotate(Vector3.forward, speed * Time.deltaTime, Space.Self);
    }
}
