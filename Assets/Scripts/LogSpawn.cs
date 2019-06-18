using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawn : MonoBehaviour
{
    float timeNext;
    public float delay;
    public Transform log;
    // Start is called before the first frame update
    void Start()
    {
      delay += Random.Range(-3f, 3f);
      timeNext = delay - 15f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time >= timeNext)
        {
          Instantiate(log, this.transform.position, Quaternion.identity);
          timeNext += delay;
        }
    }
}
