using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorShooting : MonoBehaviour
{
    public GameObject bulletRef;
    public Transform spawnPointRef;
    public static float shootForce = 1;
    public int minRandom = 0;
    public static int maxRandom = 200;
    public int tick = 0;
    public int sorted = 0;
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
            aux = Instantiate(bulletRef,
                spawnPointRef.position,
                spawnPointRef.rotation);
            aux.GetComponent<Rigidbody>().AddForce(spawnPointRef.right * (shootForce),
                ForceMode.Impulse);
            tick = 0;
            sorted = Random.Range(minRandom, maxRandom);
        }
    }
}
