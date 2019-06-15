using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float shootingAutoDestroy = 2f;

    void Start()
    {
        Destroy(this.gameObject, shootingAutoDestroy);
    }
}
