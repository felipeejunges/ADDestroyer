using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletScript : MonoBehaviour
{
    public float shootingAutoDestroy = 0.1f;
    public ParticleSystem explosion;
    public bool isPowerUp = false;
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
        if(isPowerUp == false && Shooting.bulletCount >= 1)
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
            Explode(col.gameObject.transform.position);
            Destroy(col.gameObject);
            Destroy(this.gameObject);
        }
    }

    void Explode(Vector3 position)
    {
        if (explosion != null && SceneManager.GetActiveScene().name.Equals("GameScene"))
        {
            Instantiate(explosion, position, Quaternion.identity);
        }
    }
}
