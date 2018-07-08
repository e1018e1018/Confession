using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destoycar2 : MonoBehaviour {
    public GameObject car;
    public int z;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (car.transform.position.x < z)
        {
            Destroy(gameObject);
        }
    }
}
