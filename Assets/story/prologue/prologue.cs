using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class prologue : MonoBehaviour {
    [SerializeField] protected Flowchart flowchart;
    public GameObject start;
    // Use this for initialization
    void Start () {

	}
	
	// Update is called once per frame
	void Update ()
    {

    }
    

        void OnEnable()
         {
             // Register as listener for Block events
             BlockSignals.OnBlockStart += OnBlockStart;
         }
    
        void OnDisable()
        {
            // Unregister as listener for Block events
            BlockSignals.OnBlockStart -= OnBlockStart;
        }

    static void OnBlockStart(Block block)
    {

        
    }
    public void Game()
    {
        if (gameObject.tag == "start")
        {
            var musicManager = FungusManager.Instance.MusicManager;
            musicManager.StopMusic();
            SceneManager.LoadScene(2);
        }
    }
    public void Main2()
    {
        if (gameObject.tag == "main")
        {
            SceneManager.LoadScene(0);
        }
    }

}
