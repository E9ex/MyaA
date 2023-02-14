using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Pinprefab;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();

        }
        
    }
    void SpawnPin()
    {
        Instantiate(Pinprefab,transform.position,transform.rotation);
    }
}
