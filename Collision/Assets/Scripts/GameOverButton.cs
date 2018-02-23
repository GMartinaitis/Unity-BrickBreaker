using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverButton : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
	}
    public void loadScene()
    {
        SceneManager.LoadScene("Game"); 
    }
}
