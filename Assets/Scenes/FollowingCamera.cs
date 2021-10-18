using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowingCamera : MonoBehaviour
{
	[SerializeField] GameObject objectToFollow;
	Vector3 offset = new Vector3(0, 0, -10);

	// Start is called before the first frame update
	void Start()
	{
		this.objectToFollow = GetComponent<GameObject>();
	}

	// Update is called once per frame
	void Update()
	{
		transform.position = this.objectToFollow.transform.position + this.offset;
	}
}
