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
            ScoreScript.meteoreDestroyer++;
            ScoreScript.scoreValue += (1 * col.gameObject.GetComponent<MeteorScript>().meteor.point);
            LevelingScript.makeItHarder();
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }
}
