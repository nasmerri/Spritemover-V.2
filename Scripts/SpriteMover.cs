using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteMover : MonoBehaviour
{
	public float moveSpeed;

	// Start is called before the first frame update
	void Start()
    {
        
    }

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
		{
			if (Input.GetKeyDown(KeyCode.UpArrow))
			{
				transform.position += new Vector3(0, 1, 0); 
			}
			if (Input.GetKeyDown(KeyCode.DownArrow))
			{
				transform.position += new Vector3(0, -1, 0);
			}
			if (Input.GetKeyDown(KeyCode.LeftArrow))
			{
				transform.position += new Vector3(-1, 0, 0);
			}
			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				transform.position += new Vector3(1, 0, 0);
			}

		}
		else
		{
			Move(); 
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			transform.position = new Vector3(0, 0, 0);

		}

	}

	private void Move()
	{
		if (Input.GetKey(KeyCode.UpArrow))
		{
			transform.position += new Vector3(0, moveSpeed, 0) * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			transform.position += new Vector3(0, -moveSpeed, 0) * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			transform.position += new Vector3(-moveSpeed, 0, 0) * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			transform.position += new Vector3(moveSpeed, 0, 0) * Time.deltaTime;
		}
	}
}
