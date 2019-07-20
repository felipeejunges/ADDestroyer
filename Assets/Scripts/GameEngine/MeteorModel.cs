using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorModel
{
    public string name { get; set; }
    public int point { get; set; }
    public int adType { get; set; }
    public float speedMultipler { get; set; }
    public Color color { get; set; }

    public MeteorModel(string name, int point, int adType, float speedMultipler, Color color)
    {
        this.name = name;
        this.point = point;
        this.adType = adType;
        this.speedMultipler = speedMultipler;
        this.color = color;
    }

    public string getPlacement()
    {
        if (adType == 1) {
            return "";
        }
        else if (adType == 2)
        {
            return "1Second";
        }
        else if (adType == 3)
        {
            return "5Seconds";
        }
        else if (adType == 4)
        {
            return "15Seconds";
        }
        else
        {
            return "Eternal";
        }
    }

}
