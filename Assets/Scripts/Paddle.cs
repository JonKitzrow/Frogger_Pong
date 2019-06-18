using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // move with user input
        if (transform.position.y + moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime < 4f && transform.position.y + moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime > -4f)
        {
          transform.position += new Vector3(0, moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0);
        }

        // rotate based on user input
        if (Input.GetAxis("Horizontal") > 0) // rotate right
        {
          transform.eulerAngles = new Vector3(0, 0, -10f);
        }
        else if (Input.GetAxis("Horizontal") < 0) // rotate left
        {
          transform.eulerAngles = new Vector3(0, 0, 10f);
        }
        else // no rotation
        {
          transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
