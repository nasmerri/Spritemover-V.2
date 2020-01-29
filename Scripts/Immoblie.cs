using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Immoblie : MonoBehaviour
{
	SpriteMover im;
    // Start is called before the first frame update
    void Start()
    {
		im = GetComponent<SpriteMover>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
		{
			im.enabled = !im.enabled;
        }
    }
}
