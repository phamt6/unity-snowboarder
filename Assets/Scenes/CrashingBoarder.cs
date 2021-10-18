using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashingBoarder : MonoBehaviour
{
	[SerializeField] float reloadDelay = 0.5f;
	private void OnCollisionEnter2D(Collision2D other)
	{
		if (other.collider.tag == "Ground")
		{
			Invoke("ReloadScene", reloadDelay);
		}
	}

	private void ReloadScene()
	{
		SceneManager.LoadScene(0);
	}
}
