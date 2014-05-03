using UnityEngine;
using System.Collections;

public class MoverEnemigosScript : MonoBehaviour {
	
	private Vector3 startPosition;
	
	private float newXPos = -10f;
	
	public float moveSpeed = 1f;  // same as 1.0f;
	
	public float moveDistance = 4f;
	
	// initialize an array of type GameObject with no particular number
	// but if we wanted a set number of items -- GameObject[3] <-- 3 game objects	
	//	public GameObject[] gameObjectSet;
	
	public float timeLeftUntilSpawn = 0f;
	public float startTime = 0f;
	
	public float secondsBetweenSpawn = 3f;
	
	// Use this for initialization
	void Start () {
		
		// set startPosition to the current position of the game object that this script is attached to
		// 		note: this will always be the starting position of that object, since we're in Start()
		startPosition = transform.position;
		
	}
	
	
	
	// Update is called once per frame
	void Update () {
		// newXPos++;	 // will add one to it each time
		
		// if moveDistance = 20... 20/2 = 10, so now we're moving from -10 to 10
		newXPos = Mathf.PingPong(Time.time * moveSpeed, moveDistance) - (moveDistance / 2f) ;
//		newXPos = Mathf.PingPong(Time.time * moveSpeed, moveDistance) ;
//		transform.position = new Vector3(startPosition.x, newXPos, startPosition.z);
		transform.position = new Vector3(newXPos, startPosition.y, startPosition.z);
//		print ("newXPos" + newXPos);
//		transform.position = new Vector3(startPosition.x, newXPos, startPosition.z);
//		transform.Rotate(0,0,90 * Time.deltaTime);

		timeLeftUntilSpawn = Time.time - startTime;
		
		if (timeLeftUntilSpawn >= secondsBetweenSpawn) {
			startTime = Time.time - Random.Range(0.1f,0.5f);;
			timeLeftUntilSpawn = 0;
			// Debug.Log ("Spawn one here");
			
			//			SpawnRandomObject();
		}
		
		
	}
}