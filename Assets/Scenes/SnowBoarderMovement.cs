using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBoarderMovement : MonoBehaviour
{
	Rigidbody2D player;
	[SerializeField] int rotationAmount = 5;
	// Start is called before the first frame update
	void Start()
	{
		this.player = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			Debug.Log("Left key pressed");
			this.player.AddTorque(this.rotationAmount);
		}
		else if (Input.GetKey(KeyCode.RightArrow))
		{
			Debug.Log("Right key pressed");
			this.player.AddTorque(this.rotationAmount * (-1));
		}
	}
}
