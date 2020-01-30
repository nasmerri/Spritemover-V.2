using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resize : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    //in an attempt to have the player resize the sprite, I instead made the sprite "teleport" at an angle.
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.position += new Vector3(1, 1, 1);
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.position += new Vector3(-1, -1, -1);
            }
        }
    }
}
