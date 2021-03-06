﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorShooting : MonoBehaviour
{
    public GameObject bulletRef;
    public Transform spawnPointRef;
    public static float shootForce = LevelingScript.defaultSpeed;
    public int minRandom = 0;
    public static int maxRandom = LevelingScript.defaultMaxRandom;
    public int tick = 0;
    public int sorted = 0;
    public static MeteorModel sortedMeteor = null;
    public List<GameObject> bulletsRef;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        tick++;
        if (tick >= sorted)
        {
            GameObject aux;
            bulletRef = getGameObjectFromList(bulletsRef);
            sortedMeteor = MeteorStrategy.getMeteorBySorted(Random.Range(0, 11));
            aux = Instantiate(bulletRef,
                spawnPointRef.position,
                spawnPointRef.rotation);
            aux.GetComponent<Renderer>().material.color = sortedMeteor.color;
            aux.GetComponent<Rigidbody>().AddForce(spawnPointRef.right * (sortedMeteor.speedMultipler * shootForce),
                ForceMode.Impulse);
            aux.GetComponent<MeteorScript>().meteor = sortedMeteor;
            tick = 0;
            sorted = Random.Range(minRandom, maxRandom);
        }
    }

    private GameObject getGameObjectFromList(List<GameObject> list)
    {
        int sorted = Random.Range(0, list.Count - 1);
        return list[sorted];
    }
}
