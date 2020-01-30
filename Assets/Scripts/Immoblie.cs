using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immoblie : MonoBehaviour
{
    //Declares sprite mover as im;
	SpriteMover im;
    // Start is called before the first frame update
    void Start()
    {
        //Makes "im" grab the firs SpriteMover component 
		im = GetComponent<SpriteMover>();
    }

    // Update is called once per frame
    // Creates a input for disabling the gmae object.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
		{
			im.enabled = !im.enabled;
        }
    }
}
