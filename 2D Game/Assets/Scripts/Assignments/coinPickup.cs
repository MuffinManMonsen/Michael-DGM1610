using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinPickup : GenericPickup {

	public GameObject PC;


	void OnTriggerEnter(Collider2D other) {
		if(other.name == "PC")	
			//player collects coin
	}
	else{
		//not player
	} 
}

	// Update is called once per frame
	void Update () {
		
	}
}
