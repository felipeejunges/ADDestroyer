using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorStrategy
{
    private static MeteorModel green = new MeteorModel("green", 1, 0, 1f, new Color(0, 255, 101));
    private static MeteorModel blue = new MeteorModel("blue", 3, 1, 1.2f, new Color(0, 101, 255));
    private static MeteorModel yellow = new MeteorModel("yellow", 5, 2, 1.4f, new Color(255, 255, 0));
    private static MeteorModel red = new MeteorModel("red", 7, 3, 1.6f, new Color(255, 0, 10));
    private static MeteorModel white = new MeteorModel("white", 10, 4, 1.8f, new Color(200, 200, 200));

    public static MeteorModel getMeteorByColor(string color)
    {
        if (color == "blue")
        {
            return blue;
        }
        else if (color == "green")
        {
            return green;
        }
        else if (color == "yellow")
        {
            return yellow;
        }
        else if (color == "red")
        {
            return red;
        }
        else
        {
            return white;
        }
    }

    public static MeteorModel getMeteorBySorted(int sorted)
    {
        if (sorted == 10)
        {
            return white;
        }
        else if (sorted == 0)
        {
            return green;
        }
        else if (sorted == 1 || sorted == 5 || sorted == 7)
        {
            return yellow;
        }
        else if (sorted == 3 || sorted == 9)
        {
            return red;
        }
        else
        {
            return blue;
        }
    }

}
