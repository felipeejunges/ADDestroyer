using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovement : MonoBehaviour
{
    public static float speed = LevelingScript.defaultSpeed;
    public int side = 1;

    void Update()
    {
        transform.Rotate(Vector3.forward * side, speed * Time.deltaTime, Space.Self);
    }
}
