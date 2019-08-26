using UnityEngine;

public class BoxController3 : MonoBehaviour
{
	//Notice these public variables can be adjusted in the inspector!
	public Vector2 MoveVector;
	public float SceneSize;

	private float speed = 0.1f;

    void Update()
    {
		//Draw a line to show how wide our scene is.
		Debug.DrawLine(new Vector2(-SceneSize, SceneSize), new Vector2(SceneSize, SceneSize));
		//Draw a line to show how tall our scene is.
		Debug.DrawLine(new Vector2(-SceneSize, -SceneSize), new Vector2(-SceneSize, SceneSize));

		//Now we're adding to the X and Y value of our Vector2, then multiplying it by our speed.
		Vector2 newPosition = new Vector2(transform.position.x + MoveVector.x * speed, transform.position.y + MoveVector.y * speed) ;

		//Check if the box is outside the scene, now we change the movevector instead of speed.
		//The '||' (or) operator evaluates if either condition is true.
		if (newPosition.x > SceneSize || newPosition.x < -SceneSize)
		{
			MoveVector.x *= -1f; //Flip the x move vector.
		}
		if (newPosition.y > SceneSize || newPosition.y < -SceneSize)
		{
			MoveVector.y *= -1f; //Flip the x move vector.
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
