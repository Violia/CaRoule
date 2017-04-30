/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float moveHorizontal;
	public float moveVertical;
	public Vector3 userAcceleration;
	public float speed = 2;

	private Rigidbody rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		moveHorizontal = 0.1f;//Input.acceleration.x;
		moveVertical = Input.acceleration.y;                        
		//Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		//rb.AddForce (movement * speed * 2);
//		transform.Translate(moveHorizontal, 0, moveVertical);
//	}
//}
*/

using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public float speed;
	public float AutoSpeed;
	public int type;
	private Rigidbody rb;

	void Start ()
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate ()
	{
		float moveHorizontal = 0;
		if (type == 0)
			moveHorizontal = Input.GetAxis ("Horizontal") * speed;
		else
			moveHorizontal = Input.acceleration.x * speed;
		float moveVertical = AutoSpeed;//Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement);
	}
}