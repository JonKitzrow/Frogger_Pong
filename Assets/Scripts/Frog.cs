using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frog : MonoBehaviour
{
    public GameObject logOn;
    bool jump = false;
    public Animator anim;
    int i;
    Vector3 dist, lastLogPos, deltaNext;
    public float jumpTime;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (jump) // animate transition
        {
          transform.position += (dist * Time.deltaTime / jumpTime) + deltaNext;
          deltaNext = logOn.transform.position - lastLogPos;
          lastLogPos = logOn.transform.position;
          if (logOn.transform.position.y - transform.position.y < 0.5f)
          {
            jump = false;
          }
        }
        else // update position
        {
          transform.position = logOn.transform.position; // drift with log
        }
    }

    // triggers jumping animation from current log to the next one selected
    public void setCurrentLog(GameObject g)
    {
      anim.SetTrigger("Jump");
      jump = true;
      logOn = g;
      dist = logOn.transform.position - transform.position;
      deltaNext = Vector3.zero;
      lastLogPos = logOn.transform.position;
    }
}
