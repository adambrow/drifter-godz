using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    public void LoadScene(string Level1)
    {
	SceneManager.LoadScene(Level1);
    }
}
