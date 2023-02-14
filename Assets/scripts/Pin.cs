using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 500;

    public Rigidbody2D rb;

    private void Update()
    {
        if (!isPinned)
        {
            rb.MovePosition(rb.position+Vector2.up*speed*Time.deltaTime);

        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag=="rotator")
        {
            transform.SetParent(col.transform);//beraber dönsünler diye.
            isPinned = true;
        }
    }
}
