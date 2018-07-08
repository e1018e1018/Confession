using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bus : MonoBehaviour {
    public GameObject Bus,stop;
    public Slider BusProgress;
    Rigidbody rig;
    float timer_f=0f;
    int timer_i=0;
    float timer_e = 0f;
    int timer_ei = 0;
    public static float timer_b = 0f;
    int timer_bi = 0;
    public AudioClip impact;
    AudioSource audio;
    float timer_win = 0f;
    int timer_wini = 0;
    // Use this for initialization
    void Start () {
        rig = Bus.GetComponent<Rigidbody>();
        audio = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        float x = ((stop.transform.position.x - Bus.transform.position.x) / 1.79375f) / 1000;
        BusProgress.value = 1 - x;
        timer_f += Time.deltaTime;
        timer_i = (int)timer_f;
        if (BusProgress.value <= 0.99 && timer_i >= 60 )
        {
            rig.velocity = transform.TransformDirection(Vector3.left * Random.Range(20, 40));
        }
        if (BusProgress.value > 0.99)
        {
            timer_b += Time.deltaTime;
            timer_bi = (int)timer_b;
            if(timer_bi > 10)
            {
                timer_e += Time.deltaTime;
                timer_ei = (int)timer_e;
                action.animator.SetBool("over", true);
                action.animator.SetBool("walk", false);
                action.animator.SetBool("run", false);
                action.animator.SetBool("stop", false);

                if (timer_ei == 6)
                {
                    progress.HP_Value = 1;
                    timer_b = 0;
                    timer_e = 0;
                    SceneManager.LoadScene(4);
                }
            }
            if(timer_bi <= 10 && move.copy_player > 820)
            {

                    progress.HP_Value = 1;
                    timer_win = 0;
                    timer_e = 0;
                    bus.timer_b = 0;
                    SceneManager.LoadScene(7);

            }
        }
        if (action.animator.GetBool("over") == true)
        {
            audio.PlayOneShot(impact, 1);
        }
    }
}
