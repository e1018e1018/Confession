using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class main : MonoBehaviour {

    public GameObject start, trailer, exit,about;
    public Slider loadingBar;
    public GameObject loadingImage;
    private AsyncOperation _async;

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Exit()
    {
        if (gameObject.tag == "exit")
        {
            Application.Quit();             //quit the game
        }
    }
    public void Rule()
    {
        if (gameObject.tag == "rule")
        {
            SceneManager.LoadScene(1);      //load rule scene
        }
    }
    public void Game()
    {
        if (gameObject.tag == "start")
        {
            SceneManager.LoadScene(3);      //load start scene
        }
    }
    public void About()
    {
        if (gameObject.tag == "about")
        {
            SceneManager.LoadScene(9);      //load about scene
        }
    }

}
