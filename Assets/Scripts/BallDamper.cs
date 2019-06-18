using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDamper : MonoBehaviour
{
    // reduces velocity of ball when it enters the trigger
    void OnTriggerEnter2D(Collider2D other)
    {
      if (other.tag == "Ball")
      {
        if (other.GetComponent<Rigidbody2D>().velocity.magnitude / 2 > 0.5f) // check that dempening the velocity won't slow the ball too much
        {
          other.GetComponent<Rigidbody2D>().velocity *= 0.6f; // dampen ball to 60% velocity
        }
      }
    }
}
