using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject main_ball;

	private Vector3 v3_offset_position;

	// Use this for initialization
	void Start () 
	{
		v3_offset_position = transform.position - main_ball.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () 
	{
		transform.position = main_ball.transform.position + v3_offset_position;
	}
}
