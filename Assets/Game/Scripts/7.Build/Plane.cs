using UnityEngine;
using UnityEngine.UI;

public class Plane : MonoBehaviour
{
	public float Acceleration;
	public float LiftRatio;
	public float Lift;
	public float Gravity;
	public float AirResistance;
	public Transform CameraTransform;
	public Text GameText;

	private float hSPeed = 0f;
	private float vSpeed = 0f;
	private float groundY;
	private bool inAir;

	private void Start()
	{
		groundY = transform.position.y;
		GameText.text = "";
	}

	private void Update()
	{
		bool pressingThrottle = Input.GetKey(KeyCode.Space);
		float delta = Time.deltaTime;

		//Horizontal speed
		hSPeed = (hSPeed * (1f - AirResistance * delta)); //Apply air resistance

		//Acceleration
		if (pressingThrottle)
		{
			hSPeed += (Acceleration * delta);
		}

		//Vertical speed
		vSpeed = (vSpeed * (1f - AirResistance * delta * 10f));
		vSpeed += (Gravity * delta) + (hSPeed * Lift * LiftRatio * delta);
		//vSpeed = Mathf.Min(vSpeed, MaxVSpeed);

		//Limit y position to ground.
		Vector3 newPos = transform.position + new Vector3(hSPeed, vSpeed);
		if(newPos.y < groundY)
		{
			if (inAir)
			{
				Debug.Log(vSpeed);
				inAir = false;
				if (vSpeed < -0.015f)
					GameText.text = "Ouch!";
				else
					GameText.text = "Nice Landing!";
				hSPeed *= 0.75f;
			}

			newPos.y = groundY;
			vSpeed *= -0.1f;
			hSPeed = (hSPeed * (1f - AirResistance * delta)); //Apply extra resistance for ground.
		}

		if (!inAir && transform.position.y > groundY + 0.5f)
		{
			inAir = true;
			GameText.text = "";
		}

		transform.position = newPos;

		CameraTransform.position = new Vector3(transform.position.x, CameraTransform.position.y, CameraTransform.position.z);
	}
}
