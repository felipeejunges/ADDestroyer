using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public int shootingAutoDestroy = 10;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, shootingAutoDestroy);
    }

    // Update is called once per frame
    void Update()
    {
        
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
        if(ScoreScript.scoreValue % 2 == 0) MeteorMovement.speed += 0.1f;
        else MeteorShooting.shootForce += 0.1f;

        if(ScoreScript.scoreValue % 10 == 0)
        {
            if (MeteorShooting.maxRandom > 100) MeteorShooting.maxRandom -= 1;
        }
}
}
