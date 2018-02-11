using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Trigger : MonoBehaviour {


	public int my_car = 0;
	public int yellow = 0;
	public int orange = 0;
	public int fin = 0;
	public Texture winningPicture;
	public Texture losingPicture;

	void  OnTriggerEnter (Collider other) {
		
		if(other.tag == "Player")
		{
				 if(yellow == 1 && orange == 0) my_car=2;
			else if(orange == 1 && yellow == 0) my_car=2;
			else if(orange == 1 && yellow == 2) my_car=3;
			else if(orange == 2 && yellow == 1) my_car=3;
			else 								my_car=1;
		}
		else if(other.tag == "Yellow")
		{
				 if(my_car == 1 && orange == 0) yellow=2;
			else if(orange == 1 && my_car == 0) yellow=2;
			else if(orange == 1 && my_car == 2) yellow=3;
			else if(orange == 2 && my_car == 1) yellow=3;
			else 								yellow=1;
		}
		else if(other.tag == "Orange")
		{
				 if(my_car == 1 && yellow == 0) orange=2;
			else if(yellow == 1 && my_car == 0) orange=2;
			else if(yellow == 1 && my_car == 2) orange=3;
			else if(yellow == 2 && my_car == 1) orange=3;
			else 								orange=1;
		}
	}

	void OnGUI()
	{
		if(my_car==1)	//you came 1st
		{
			GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), winningPicture);
			GUI.Label ( new Rect(650, 20, 150, 30), "You finished 1st!");
			if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
			{
				Application.LoadLevel ("startMenu");
			}
			if(yellow==2) //you came 1st & yellow came 2nd
			{
				GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), winningPicture);
				if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
				{
					Application.LoadLevel ("startMenu");
				}
				GUI.Label ( new Rect(650, 20, 150, 30), "You finished 1st!");
				GUI.Label ( new Rect(650, 35, 150, 30), "Yellow finished 2nd!");
				
				if(orange==3) //you came 1st & yellow came 2nd & orange came 3rd
				{
					GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), winningPicture);
					if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
					{
						Application.LoadLevel ("startMenu");
					}
					GUI.Label ( new Rect(650, 20, 150, 30), "You finished 1st!");
					GUI.Label ( new Rect(650, 35, 150, 30), "Yellow finished 2nd!");
					GUI.Label ( new Rect(650, 50, 150, 30), "Orange finished 3rd!");
				}
			}
			if(orange==2)  //you came 1st & orange came 2nd 
			{
				GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), winningPicture);
				if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
				{
					Application.LoadLevel ("startMenu");
				}
				GUI.Label ( new Rect(650, 20, 150, 30), "You finished 1st!");
				GUI.Label ( new Rect(650, 35, 150, 30), "Orange finished 2nd!");
				
				if(yellow==3)  //you came 1st & orange came 2nd & yellow came 3rd
				{
					GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), winningPicture);
					if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
					{
						Application.LoadLevel ("startMenu");
					}
					GUI.Label ( new Rect(650, 20, 150, 30), "You finished 1st!");
					GUI.Label ( new Rect(650, 35, 150, 30), "Orange finished 2nd!");
					GUI.Label ( new Rect(650, 50, 150, 30), "Yellow finished 3rd!");
				}
			}
		}
		if(yellow==1)   //yellow came 1st 
		{
			GUI.Label ( new Rect(650, 20, 150, 30), "Yellow finished 1st!");

			if(my_car==2) //yellow came 1st & you came 2nd 
			{
				GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), losingPicture);
				if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
				{
					Application.LoadLevel ("startMenu");
				}
				GUI.Label ( new Rect(650, 20, 150, 30), "Yellow finished 1st!");
				GUI.Label ( new Rect(650, 35, 150, 30), "You finished 2nd!");
				
				if(orange==3) //you came 1st & yellow came 2nd & orange came 3rd
				{
					GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), losingPicture);
					if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
					{
						Application.LoadLevel ("startMenu");
					}
					GUI.Label ( new Rect(650, 20, 150, 30), "Yellow finished 1st!");
					GUI.Label ( new Rect(650, 35, 150, 30), "You finished 2nd!");
					GUI.Label ( new Rect(650, 50, 150, 30), "Orange finished 3rd!");
				}
			}
			if(orange==2)  //yellow came 1st & orange came 2nd 
			{
				GUI.Label ( new Rect(650, 20, 150, 30), "Yellow finished 1st!");
				GUI.Label ( new Rect(650, 35, 150, 30), "Orange finished 2nd!");
				
				if(my_car==3)  //yellow came 1st & orange came 2nd & you came 3rd
				{
					GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), losingPicture);
					if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
					{
						Application.LoadLevel ("startMenu");
					}
					GUI.Label ( new Rect(650, 20, 150, 30), "Yellow finished 1st!");
					GUI.Label ( new Rect(650, 35, 150, 30), "Orange finished 2nd!");
					GUI.Label ( new Rect(650, 50, 150, 30), "You finished 3rd!");
				}
			}
		}
		if(orange==1)   //orange came 1st 
		{
			GUI.Label ( new Rect(650, 20, 150, 30), "Orange finished 1st!");

			if(my_car==2) //yellow came 1st & you came 2nd 
			{
				GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), losingPicture);
				if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
				{
					Application.LoadLevel ("startMenu");
				}
				GUI.Label ( new Rect(650, 20, 150, 30), "Orange finished 1st!");
				GUI.Label ( new Rect(650, 35, 150, 30), "You finished 2nd!");
				
				if(yellow==3) //you came 1st & yellow came 2nd & orange came 3rd
				{
					GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), losingPicture);
					if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
					{
						Application.LoadLevel ("startMenu");
					}
					GUI.Label ( new Rect(650, 20, 150, 30), "Orange finished 1st!");
					GUI.Label ( new Rect(650, 35, 150, 30), "You finished 2nd!");
					GUI.Label ( new Rect(650, 50, 150, 30), "Yellow finished 3rd!");
				}
			}
			if(yellow==2)  //yellow came 1st & orange came 2nd 
			{
				GUI.Label ( new Rect(650, 20, 150, 30), "Orange finished 1st!");
				GUI.Label ( new Rect(650, 35, 150, 30), "Yellow finished 2nd!");
				
				if(my_car==3) //yellow came 1st & orange came 2nd & you came 3rd
				{
					GUI.Label ( new Rect(Screen.width/2 - 256, Screen.height/2 - 64, 512, 128), losingPicture);
					if(GUI.Button ( new Rect(Screen.width/2 - 200, Screen.height/2 + 100,400,40), "Continue"))
					{
						Application.LoadLevel ("startMenu");
					}
					GUI.Label ( new Rect(650, 20, 150, 30), "Orange finished 1st!");
					GUI.Label ( new Rect(650, 35, 150, 30), "Yellow finished 2nd!");
					GUI.Label ( new Rect(650, 50, 150, 30), "You finished 3rd!");
				}
			}
		}
	}
}