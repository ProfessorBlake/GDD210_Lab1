using UnityEngine;

public class BoxController2 : MonoBehaviour
{
	public float SceneWidth = 5f;

	private float speed = 0.1f;

    void Update()
    {
		//Draw a ling to show how wide our scene is.
		Debug.DrawLine(new Vector2(-SceneWidth, 2f), new Vector2(SceneWidth, 2f));

		//Create a new Vector2 and set it to where the box should move.
		// 'transform' refers the transform component of the gameobject this script is attached to (Box).
		Vector2 newPosition = new Vector2(transform.position.x + speed, transform.position.y);

		//Check if the box is outside the scene.
		if (newPosition.x > SceneWidth)
		{
			speed = -0.1f; //Move left.
		}
		else if (newPosition.x < -SceneWidth)
		{
			speed = 0.1f; //Move right.
		}

		//Set the transforms position variable to equal our Vector2.
		transform.position = newPosition;

		//If we press mouse button 0 (left click), reset the box position.
		if (Input.GetMouseButtonDown(0))
		{
			transform.position = Vector2.zero; // Vector2.zero is the same as 'new Vector2(0f, 0f)'.
		}
	}
}
