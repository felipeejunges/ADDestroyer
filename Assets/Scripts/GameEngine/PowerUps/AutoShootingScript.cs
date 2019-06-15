using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoShootingScript : MonoBehaviour
{
    public float speed = 800f;
    public int side = 1;
    float timer = 0;
    float wantingTime = 3f;
    public GameObject bulletRef;
    public Transform spawnPointRef;
    public float shootForce = 1.5f;

    void Update()
    {
        transform.Rotate(Vector3.forward * side, speed * Time.deltaTime, Space.Self);

        timer += Time.deltaTime;
        if (timer > wantingTime)
        {
            GameObject aux;
            aux = Instantiate(bulletRef,
                spawnPointRef.position,
                spawnPointRef.rotation);
            aux.GetComponent<Rigidbody>().AddForce(spawnPointRef.right * -(shootForce),
                ForceMode.Impulse);
            aux.GetComponent<BulletScript>().isPowerUp = true;
            timer = 0;
        }
    }
}
