using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	private Rigidbody ball_rigidbody;
	public float f_ball_speed;

	void Start()
	{
		ball_rigidbody = GetComponent<Rigidbody> ();
	}


	// Update is called once per frame
	void Update ()
    {
		
	}

    void FixedUpdate()
    {
		float f_move_horizontal = Input.GetAxis ("Horizontal");
		float f_move_vertical = Input.GetAxis ("Vertical");

		Vector3 forces_ball_axis = new Vector3 (f_move_horizontal, 0, f_move_vertical);

		ball_rigidbody.AddForce (forces_ball_axis*f_ball_speed);
    }
}
