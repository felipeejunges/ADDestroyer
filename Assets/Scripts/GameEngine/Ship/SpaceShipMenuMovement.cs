﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipMenuMovement : MonoBehaviour
{
    public float speed = 10f;
    public int side = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * side, speed * Time.deltaTime, Space.Self);
    }
}
