using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{ 
    public GameObject bulletRef;
    public Transform spawnPointRef;
    public float shootForce = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject aux;
            aux = Instantiate(bulletRef, 
                spawnPointRef.position, 
                spawnPointRef.rotation);
            aux.GetComponent<Rigidbody>().AddForce(spawnPointRef.right * (shootForce * ( - 1)),
                ForceMode.Impulse);
        }
    }
}
