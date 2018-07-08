using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class up : MonoBehaviour {
    float TranslateSpeed = 2f;
    public GameObject img;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        img.transform.Translate(Vector3.up * TranslateSpeed);
        if (img.transform.position.y >= 6721f)
        {
            SceneManager.LoadScene(0);
        }
        if (Input.GetMouseButton(0))
        {
            TranslateSpeed = 5f;
        }
        else
        {
            TranslateSpeed = 2f;
        }
    }
}
