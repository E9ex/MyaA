using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotator : MonoBehaviour
{
    public float speed = 100f;

    private void Update()
    {
        transform.Rotate(0f,0,speed*Time.deltaTime);//transform.rotate döndürme: icin
    }
}
