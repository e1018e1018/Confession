using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class button : MonoBehaviour {
    public GameObject main;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Main2()
    {
        if (gameObject.tag == "main")
        {
            SceneManager.LoadScene(0);
        }
    }
}
