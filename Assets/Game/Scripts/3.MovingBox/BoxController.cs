using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
	private float speed;

    void Start()
    {
		Debug.Log("Starting to move the box.");
		speed = 0.01f;
    }

    void Update()
    {
		//Create a new Vector2 and set it to where the box should move.
		// 'transform' refers the transform component of the gameobject this script is attached to (Box).
		Vector2 newPosition = new Vector2(transform.position.x + speed, transform.position.y);

		//Set the transforms position variable to equal our Vector2.
		transform.position = newPosition;

		//If we press mouse button 0 (left click), reset the box position.
		if(Input.GetMouseButtonDown(0))
		{
			transform.position = Vector2.zero; // Vector2.zero is the same as 'new Vector2(0f, 0f)'.
		}
    }
}
