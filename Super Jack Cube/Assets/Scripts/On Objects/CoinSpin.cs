﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is just to animate the coins a bit
        transform.Rotate(new Vector3(0, 0, 20) * Time.deltaTime);
    }
}
