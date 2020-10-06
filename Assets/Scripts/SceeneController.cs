using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceeneController : MonoBehaviour {

	// Use this for initialization
	public void changeLevel(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void exitGame()
    {
        Application.Quit();
    }

}
