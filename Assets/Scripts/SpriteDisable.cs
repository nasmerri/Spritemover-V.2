﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteDisable : MonoBehaviour
{// declares gameobject
	public GameObject ObjectToDisable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //Deactivates gameobject 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
		{
			ObjectToDisable.SetActive(!ObjectToDisable.activeSelf);

		}
    }
}
