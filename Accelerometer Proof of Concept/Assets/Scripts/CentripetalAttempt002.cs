﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentripetalAttempt002 : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb.velocity);
    }
}
