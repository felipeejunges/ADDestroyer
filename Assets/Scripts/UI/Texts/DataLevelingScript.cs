using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DataLevelingScript : MonoBehaviour
{
    Text dataLevelingText;

    // Start is called before the first frame update
    void Start()
    {
        dataLevelingText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        string force = "Force: " + MeteorShooting.shootForce;
        string speed = "Speed: " + MeteorMovement.speed;
        string maxRandom = "maxRandom: " + MeteorShooting.maxRandom;
        dataLevelingText.text = force + " / " + speed + " / " + maxRandom;
    }
}
