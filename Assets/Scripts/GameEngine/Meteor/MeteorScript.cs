using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeteorScript : MonoBehaviour
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
        if (col.gameObject.tag == "Lose")
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
