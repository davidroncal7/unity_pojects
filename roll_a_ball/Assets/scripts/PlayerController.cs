using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
	public float f_ball_speed;
	public Text tx_count_text;
	public Text tx_win_text;

	private Rigidbody ball_rigidbody;
	private const string sz_pick_up = "Pick Up";
	private int i8_count;

	void Start()
	{
		ball_rigidbody = GetComponent<Rigidbody> ();
		i8_count = 0;
		SetCountText ();
		tx_win_text.text = "";
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

	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag (sz_pick_up)) 
		{
			other.gameObject.SetActive (false);
			++i8_count;
			SetCountText ();
		}
	}

	void SetCountText()
	{
		tx_count_text.text = "Count: " + i8_count.ToString ();
		if (i8_count >= 10) 
		{
			tx_win_text.text = "You Win";
		}
	}
}
//Destroy(other.gameObject);