using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{ 
    public GameObject bulletRef;
    public Transform spawnPointRef;
    public float shootForce = 1;
    public static int maxBullet = 10;
    public static int bulletCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShootingOnPress();
        }
        if(Input.GetMouseButtonDown(0))
        {
            ShootingOnPress();
        }
    }

    private void ShootingOnPress()
    {
        if(bulletCount < maxBullet)
        {
            bulletCount++;
            GameObject aux;
            aux = Instantiate(bulletRef,
                spawnPointRef.position,
                spawnPointRef.rotation);
            aux.GetComponent<Rigidbody>().AddForce(spawnPointRef.right * (shootForce),
                ForceMode.Impulse);
        }

    }
}
