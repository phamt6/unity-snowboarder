using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishingLine : MonoBehaviour
{
	[SerializeField] int reloadDelay = 2;
	private void OnTriggerEnter2D(Collider2D collider)
	{

		if (collider.tag == "Player")
		{
			Invoke("reloadScene", this.reloadDelay);
		}
	}

	private void reloadScene()
	{
		SceneManager.LoadScene(0);
	}
}
