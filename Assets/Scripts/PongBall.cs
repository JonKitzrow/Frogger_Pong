﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    public Rigidbody2D rb;
    public float accel, maxVelocity;
    public GameObject frog;

    // Start is called before the first frame update
    void Start()
    {
        // initialize with random velocity
        rb.velocity = new Vector3(Random.Range(0.5f, 5f), Random.Range(0.5f, 5f), 0);
    }

    // Update is called once per frame
    void Update()
    {
      // gradually increase the speed to increment difficulty until max-velocity is reached
      if (rb.velocity.magnitude < maxVelocity)
      {
        rb.velocity *= 1 + (accel/100f) * Time.deltaTime;
      }
    }

    public void setLog(GameObject g)
    {
      frog.GetComponent<Frog>().setCurrentLog(g);
    }
}
