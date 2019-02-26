using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour {

	public string stopLight;
	public bool isUtahn = true;

	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(stopLight == "Red"){
			 //Block of code that is run if the condition is met
			 if(isUtahn){
			 	print("Thank you for stopping at the red light!");
			}
		}
		else if(stopLight == "Yellow"){
			if(isUtahn){
				print("You've got this brah!");
			}
			else{
				print()	
		}
		else if(stopLight == "Green"){
			print("Check phone, turn up radio, sit at the light until almost yellow, then go!");	
		}
		else{
			print("Sorry, you are driving in Utah!");
		}
	}
}

