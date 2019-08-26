using UnityEngine;

public class ArrayManager : MonoBehaviour
{
	//Array of 3 strings.
	private string[] Friends = new string[3];

	private void Start()
	{
		//Set our friends names.
		Friends[0] = "Alice"; //The first index of an array is 0.
		Friends[1] = "Bob";
		Friends[2] = "Charlie";

		//Our for loop will create a temporary variable 'i' and set it to 0.
		//While i is less than the length of Friends (3) it will go through our loop.
		//After each loop, it will add 1 to i and check the condition again.
		for(int i = 0; i < Friends.Length; i++)
		{
			Debug.Log(Friends[i]); //Log the item in Friends at index i.
		}

		//A foreach loop will look for all the strings in 'Friends' and assign them to 'name' inside the loop.
		foreach(string name in Friends)
		{
			Debug.Log(name);
		}
	}
}
