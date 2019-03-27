using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour {
	// public int bottles = 100;
	public bool isRaining = true;

	// Use this for initialization
	void Start () {
			//For loop
			// for(int i=1; i <= bottles; i++){
			// 	print(i +" bottles of elixir");
			// }	

			// Do While Loop
			// bool shouldContinue = false;

			// do
			// {
			// 	print ("Hello World")
			
			// }while(shouldContinue == true);

			//ForEach Loop
			string[] strings = new string[3];

			strings[0] = "First string";
			strings[1] = "Second string";
			strings[3] = "Third string";

			foreach(string item in strings)
			{
				print (item);
			}

			// while(bottles <= 100){
			// 	print(bottles +" bottles of elixir");
			// 	bottles ++;
			// }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
