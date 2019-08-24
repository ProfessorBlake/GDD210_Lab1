using UnityEngine;

public class BoxController4 : MonoBehaviour
{
	private Vector2 moveVector;
	private float speed;
	private float sceneSize;

    void Start()
    {
		speed = 0.5f;
		sceneSize = 4f;

		//Call a new function to randomize our direction.
		RandomizeMoveVector();
    }
	
    void Update()
    {
		Debug.DrawLine(new Vector2(-sceneSize, sceneSize), new Vector2(sceneSize, sceneSize));
		Debug.DrawLine(new Vector2(-sceneSize, -sceneSize), new Vector2(-sceneSize, sceneSize));

		if (Input.GetMouseButtonDown(0))
		{
			RandomizeMoveVector(); //Randomize our move vector.
			transform.position = Vector2.zero; //Reset position.
		}

		Vector2 newPosition = new Vector2(transform.position.x + moveVector.x * speed, transform.position.y + moveVector.y * speed);

		if (newPosition.x > sceneSize || newPosition.x < -sceneSize)
		{
			moveVector.x *= -1f;
		}
		if (newPosition.y > sceneSize || newPosition.y < -sceneSize)
		{
			moveVector.y *= -1f;
		}
		
		transform.position = newPosition;
	}

	private void RandomizeMoveVector()
	{
		moveVector = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
	}
}
