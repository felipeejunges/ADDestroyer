using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingScript : MonoBehaviour
{
    public static float defaultSpeed = 250;
    public static int defaultMaxRandom = 200;
    public static float defaultShootForce = 1;

    public static void newGame()
    {
        MeteorMovement.speed = defaultSpeed;
        MeteorShooting.maxRandom = defaultMaxRandom;
        MeteorShooting.shootForce = defaultShootForce;
        ScoreScript.scoreValue = 0;
        ScoreScript.meteoreDestroyer = 0;
    }

    public static void endGame()
    {
        //saveScore
    }

    public static void makeItHarder()
    {
        if (ScoreScript.meteoreDestroyer % 2 == 0) MeteorMovement.speed += 10f;
        else MeteorShooting.shootForce += 0.1f;

        if (ScoreScript.meteoreDestroyer % 5 == 0)
        {
            if (MeteorShooting.maxRandom >= 5) MeteorShooting.maxRandom -= 5;
        }
        if (ScoreScript.meteoreDestroyer % 10 == 0)
        {
            // add new meteor shooter
        }
    }
}
