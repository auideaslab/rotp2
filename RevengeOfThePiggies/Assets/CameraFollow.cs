﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform piggy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 goal = new Vector3(piggy.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, goal, Time.deltaTime*5);
    }
}
