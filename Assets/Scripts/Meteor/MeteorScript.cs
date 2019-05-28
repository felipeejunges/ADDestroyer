using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MeteorScript : MonoBehaviour
{
  
    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Lose")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
