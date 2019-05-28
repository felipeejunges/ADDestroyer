using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletTextScript : MonoBehaviour
{
    Text bulletText;

    // Start is called before the first frame update
    void Start()
    {
        bulletText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletText.text = "Bullets: " + (10 - Shooting.bulletCount);
    }
}
