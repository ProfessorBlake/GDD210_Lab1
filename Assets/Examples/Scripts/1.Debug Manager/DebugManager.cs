using UnityEngine;

public class DebugManager : MonoBehaviour
{
	//Public variables are accessible anywhere inside this class, and by other classes.
	public string MyName = "Student";
	public int Age = 20;

	//Private variables are only accessible inside this class. Adding [serializedfield] attribute allows us to edit them in the inspector.
	[SerializeField] private float gpa = 3.8f;
	[SerializeField] private bool iHaveACar = true;

	//Start is a function inhereted from MonoBehaviour, which is called at the start of the game.
	void Start()
    {
		Debug.Log("My name is " + MyName + ". I am " + Age + " and my GPA is " + gpa); //Normal Debug.log

		Debug.LogFormat("My name is {0}. I am {1} and my GPA is {2}", MyName, Age, gpa); //Using Debug.LogFormat

		//Using an if statement.
		if (iHaveACar == true)
		{
			Debug.Log("I have a car!");
		}
    }
}