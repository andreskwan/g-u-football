using UnityEngine;
using System.Collections;

public class MoveToCatchBallScript : MonoBehaviour {
	
//	private Vector3 startPosition;
//	
//	private float newXPos = -10f;
//	
//	public  float moveSpeed = 1f;  // same as 1.0f;
//	
//	public  float moveDistance = 4f;
//
//	public  int thresholdTime = 1;
//
//	public  GameObject objToFollow;
//
	public  int deg = 90;
//
//	public int moveX = 0;
//
//	public int moveY = 0;

	public AnimationCurve Zcurve; 
	public float TotalRotatingTime = 0.0f;



	// initialize an array of type GameObject with no particular number
	// but if we wanted a set number of items -- GameObject[3] <-- 3 game objects	
	//	public GameObject[] gameObjectSet;
	
//	public float timeLeftUntilSpawn = 0f;
//	public float startTime = 0f;
//	
//	public float secondsBetweenSpawn = 3f;
	
	// Use this for initialization
	void Start () {
		
//		// set startPosition to the current position of the game object that this script is attached to
//		// 		note: this will always be the starting position of that object, since we're in Start()
//		startPosition = transform.position;
//
//		transform.Rotate(0,0,45);
//
//		objToFollow = GameObject.Find("pulpy");

		StartCoroutine("Travel");

		
	}

	IEnumerator Travel(){
		//keep track

		float ElapsedTime = 0.0f;

		while(ElapsedTime < TotalRotatingTime){
//			float zDeg = Zcurve.Evaluate(ElapsedTime);
			//testing with radians
			//it work with radians
			float zDeg = Mathf.Cos(ElapsedTime);
//			float zDeg = 0;


			transform.Rotate(0,0,zDeg);
			print ( "X = ElapsedTime: " + ElapsedTime + "  Y = zDeg: " + zDeg);
//			print (  );
			yield return null;

			//which values takes Time.deltaTIme
			//zDeg should be in radians or degrees?
			ElapsedTime += Time.deltaTime;
		}
	}



	
	// Update is called once per frame
	void Update () {

////		// newXPos++;	 // will add one to it each time
////		int i = 100;
////		print("objToFollow.transform.position" + objToFollow.transform.position * i);
////		print("arrow transform.position" + transform.position);
////		print("arrow transform.rotation " + transform.rotation );
////
////		var Vector3 vecRes = objToFollow.transform.position * i - transform.position;
////		
////		var newRotation = Quaternion.LookRotation().eulerAngles;
////		newRotation.x = 0;
////		newRotation.y = 0;
////		transform.rotation = Quaternion.Euler(newRotation);
////		print("arrow transform.rotation " + transform.rotation );
//
//		float rad = deg * Mathf.Deg2Rad;
//
//		Vector3 relative = transform.InverseTransformPoint(objToFollow.transform.position);
//		float angle = Mathf.Atan2(relative.y, relative.x) * Mathf.Rad2Deg;
//		print("degree" + deg );
////		print("angle + PI " + (angle + (Mathf.PI)/2.0f) );
//
//		transform.Rotate(0, 0, angle + rad );
//		transform.position = new Vector3(moveX, moveY, 0);
//
////		// if moveDistance = 20... 20/2 = 10, so now we're moving from -10 to 10
////		newXPos = Mathf.PingPong(Time.time * moveSpeed, moveDistance) - (moveDistance / 2f) ;
////		
//////		transform.position = new Vector3(newXPos, startPosition.y, startPosition.z);
////		if( true){
////
////			transform.Rotate(0,0,0);
//////			Mathf.PingPong(Time.time,thresholdTime)
////			print(" Mathf.PingPong(Time.time, 3) " +  Mathf.PingPong(Time.time, thresholdTime));
////		}else{
////			transform.Rotate(0,0,0);
////			print("angulo mayor a 135");
////		}
////		timeLeftUntilSpawn = Time.time - startTime;
////		
////		if (timeLeftUntilSpawn >= secondsBetweenSpawn) {
////			startTime = Time.time - Random.Range(0.1f,0.5f);;
////			timeLeftUntilSpawn = 0;
////			// Debug.Log ("Spawn one here");
////			
////			//			SpawnRandomObject();
////		}
		
	}
}