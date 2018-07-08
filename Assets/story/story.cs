using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Fungus;

public class story : MonoBehaviour {
    //[SerializeField] protected Flowchart flowchart;
    [SerializeField] protected Flowchart flowchart;
    public AudioClip impact;
    public AudioSource audio;

    // Use this for initialization
    void Start () {
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void Main2()
    {
        if (gameObject.tag == "main")
        {
            var musicManager = FungusManager.Instance.MusicManager;
            musicManager.StopMusic();
            SceneManager.LoadScene(0);

        }
    }
    public void Retry()
    {
        if (gameObject.tag == "start")
        {
            var musicManager = FungusManager.Instance.MusicManager;
            musicManager.StopMusic();
            SceneManager.LoadScene(2);
        }
    }
}
