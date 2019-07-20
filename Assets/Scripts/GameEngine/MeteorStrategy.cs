using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorStrategy
{
    private static MeteorModel green = new MeteorModel("green", 1, 1, 1f, new Color(0.1f, 0.8f, 0.3f));
    private static MeteorModel blue = new MeteorModel("blue", 2, 2, 1.15f, new Color(0.1f, 0.5f, 0.8f));
    private static MeteorModel yellow = new MeteorModel("yellow", 3, 3, 1.3f, new Color(1, 0.8f, 0));
    private static MeteorModel red = new MeteorModel("red", 4, 4, 1.4f, new Color(1, 0, 0.03f));
    private static MeteorModel white = new MeteorModel("white", 5, 5, 1.5f, new Color(200, 200, 200));

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
