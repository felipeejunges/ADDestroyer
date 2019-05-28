using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float shootingAutoDestroy = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, shootingAutoDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        if(Shooting.bulletCount >= 1)
        {
            Shooting.bulletCount--;
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Alvo")
        {
            ScoreScript.scoreValue++;
            makeItHarder();
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }

    private void makeItHarder()
    {
        if(ScoreScript.scoreValue % 2 == 0) MeteorMovement.speed += 2f;
        else MeteorShooting.shootForce += 0.2f;

        if(ScoreScript.scoreValue % 10 == 0)
        {
            if (MeteorShooting.maxRandom > 50) MeteorShooting.maxRandom -= 1;
        }
}
}
