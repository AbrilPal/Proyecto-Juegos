using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso : MonoBehaviour
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
        transform.position = start + new Vector2(0, Mathf.Sin(Time.time));
    }
}
