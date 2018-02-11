// Converted from UnityScript to C# at http://www.M2H.nl/files/js_to_c.php - by Mike Hergaarden
// Do test the code! You usually need to change a few small bits.

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BrakingSectorScript : MonoBehaviour {
	float maxBrakeTorque = 100;
	float minCarSpeed = 20;


	void  OnTriggerStay (Collider other){
		if (other.tag == "AI"){
			float controlCurrentSpeed = other.transform.root.GetComponent<AICarScript>().currentSpeed;
			if (controlCurrentSpeed >= minCarSpeed){
				other.transform.root.GetComponent<AICarScript>().inSector = true;
				other.transform.root.GetComponent<AICarScript>().wheelRR.brakeTorque = maxBrakeTorque;
				other.transform.root.GetComponent<AICarScript>().wheelRL.brakeTorque = maxBrakeTorque;
			}
			else {
				other.transform.root.GetComponent<AICarScript>().inSector = false;
				other.transform.root.GetComponent<AICarScript>().wheelRR.brakeTorque = 0;
				other.transform.root.GetComponent<AICarScript>().wheelRL.brakeTorque = 0;
			}
			other.transform.root.GetComponent<AICarScript>().isBraking = true;
		}
	}

	void  OnTriggerExit ( Collider other  ){
		if (other.tag == "AI"){
			other.transform.root.GetComponent<AICarScript>().inSector = false;
			other.transform.root.GetComponent<AICarScript>().wheelRR.brakeTorque = 0;
			other.transform.root.GetComponent<AICarScript>().wheelRL.brakeTorque = 0;
			other.transform.root.GetComponent<AICarScript>().isBraking = false;
		}
	}

	[RPC]
	void  Test ()
	{
		
	}
}