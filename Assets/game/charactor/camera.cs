using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class camera : MonoBehaviour {
    public GameObject cam;
    public GameObject player;
    public Camera firstPersonCamera;
    public Camera SecondCamera;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {    
        cam.transform.position = new Vector3(player.transform.position.x+12.8697f, player.transform.position.y+ 14.3f, player.transform.position.z- 30.9f);//set camera position fix to girl
    }

}
