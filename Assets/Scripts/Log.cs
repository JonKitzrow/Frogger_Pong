using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Log : MonoBehaviour
{
    int direction = 1;
    public float speed;
    Color thisColor;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x > 0) // set direction based on spawn location
        {
          direction = -1;
        }
        thisColor = GetComponent<SpriteRenderer>().color;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime * direction; // update position
    }

    void OnTriggerStay2D(Collider2D other)
    {
      if (other.tag == "Ball")
      {
        GetComponent<SpriteRenderer>().color = new Color(100f, 60f, 60f);
        if (Input.GetKeyDown("space"))
        {
          other.GetComponent<PongBall>().setLog(this.gameObject);
        }
      }
    }

    void OnTriggerExit2D(Collider2D other)
    {
      GetComponent<SpriteRenderer>().color = thisColor;
    }
}
