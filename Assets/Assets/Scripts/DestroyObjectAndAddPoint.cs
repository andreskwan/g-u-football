using UnityEngine;
using System.Collections;

public class DestroyObjectAndAddPoint : MonoBehaviour {
	
	int myScore = 0;
	
	public TextMesh scoreText;

	public GameObject ball; 
	
	// with 3D, it would be OnTriggerEnter(Collider collisonObject)

	void Start() {                 
		ball = GameObject.FindWithTag("TagBall");
	}

	void OnTriggerEnter2D(Collider2D collisionObject) {

//		if (collisionObject == ball){

			// remove the object from gameplay
			Destroy(collisionObject.gameObject);

//			ball = collisionObject.gameObject;

//			ball.transform.localScale = new Vector3(0.5f,0.5f,0.5f);

			// add a point to the player's score
			// AKA myScore++;
			myScore = myScore + 1;
			
			// display the player's score
			Debug.Log ("My score is "  + myScore + " point(s)");
		
		
			scoreText.text = "My score is: " + myScore;
//		}else{
//			scoreText.text = "no es la bola";
//		}

	}
}

