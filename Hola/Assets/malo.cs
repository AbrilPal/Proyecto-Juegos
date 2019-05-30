using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class malo : MonoBehaviour
{
    private Vector2 start;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = start + new Vector2(Mathf.Sin(Time.time), 0);
    }
}
