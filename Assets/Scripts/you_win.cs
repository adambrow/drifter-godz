using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class you_win : MonoBehaviour
{
    public GameObject YOUWIN;

    private void OnTriggerEnter(Collider other)
    {
	if (other.tag == "Player")
	{
		YOUWIN.SetActive(true);
		Time.timeScale = 0f;
	}

    }
}
