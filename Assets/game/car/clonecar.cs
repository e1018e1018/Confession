using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clonecar : MonoBehaviour
{
    public GameObject car;
    GameObject carcopy;
    Rigidbody rig;
    float nt;
    public int z;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float sec = Random.Range(15,30);
        nt = nt + Time.deltaTime / sec;
        Renderer rend = GetComponent<Renderer>();
        if (nt > 0.5f)
        {
            float r = Random.Range(0f, 1f);
            float g = Random.Range(0f, 1f);
            float b = Random.Range(0f, 1f);
            Color color = new Color(r, g, b);
            carcopy = GameObject.Instantiate(this.car) as GameObject;
            Transform cpy0 = carcopy.transform.GetChild(1).GetChild(0);
            Transform cpy1 = carcopy.transform.GetChild(0).GetChild(1);
            Transform cpy3 = carcopy.transform.GetChild(0).GetChild(3);
            Transform cpy4 = carcopy.transform.GetChild(0).GetChild(4);
            carcopy.SetActive(true);
            carcopy.transform.Translate(new Vector3(z, 0, 0), Space.World);
            rig = carcopy.GetComponent<Rigidbody>();
            rig.AddForce(Vector3.right * 5000);
            rig.velocity = transform.TransformDirection(Vector3.right * Random.Range(100,150));
            cpy0.GetComponent<Renderer>().material.color = color;
            cpy1.GetComponent<Renderer>().material.color = color;
            cpy3.GetComponent<Renderer>().material.color = color;
            cpy4.GetComponent<Renderer>().material.color = color;
            nt = 0;
        }
    }
}
