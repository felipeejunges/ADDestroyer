using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingScript : MonoBehaviour
{
    public static float defaultSpeed = 10f;
    public static int defaultMaxRandom = 200;
    public static float defaultShootForce = 1;

    public static void newGame()
    {
        MeteorMovement.speed = defaultSpeed;
        MeteorShooting.maxRandom = defaultMaxRandom;
        MeteorShooting.shootForce = defaultShootForce;
        ScoreScript.scoreValue = 0;
    }

    public static void endGame()
    {
        //saveScore
    }

    public static void makeItHarder()
    {
        if (ScoreScript.scoreValue % 2 == 0) MeteorMovement.speed += 2f;
        else MeteorShooting.shootForce += 0.2f;

        if (ScoreScript.scoreValue % 5 == 0)
        {
            if (MeteorShooting.maxRandom >= 10) MeteorShooting.maxRandom -= 5;
        }
        if (ScoreScript.scoreValue % 10 == 0)
        {
            // add new meteor shooter
        }
    }
}
