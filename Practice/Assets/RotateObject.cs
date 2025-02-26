﻿using UnityEngine;
using System.Collections;

public class RotateObject : MonoBehaviour
{

    public Vector3 RotateAmount;  // degrees per second to rotate in each axis. Set in inspector.

    public float speed;
    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(RotateAmount * speed);
    }
}
