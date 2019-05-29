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


}
