using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class move : MonoBehaviour {
    public  GameObject player,trigger;
    float timer_f = 0f;
    int timer_i = 0;
    float timer_e = 0f;
    int timer_ei = 0;
    float timer_win = 0f;
    int timer_wini = 0;
    public static float copy_player;
    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        copy_player = player.transform.position.x;
        timer_e += Time.deltaTime;
        timer_ei = (int)timer_e;
        print(timer_ei);
        //print(timer_ei);
        AnimatorStateInfo currentState = senpai.animator.GetCurrentAnimatorStateInfo(0);
        if (Input.GetMouseButton(0))
        {
            if (action.animator.GetBool("over") == false && player.transform.position.x <=820)
            {
                if (player.transform.rotation.y >= 0.7f)
                {
                    transform.Translate(Vector3.forward * Time.deltaTime * 20);
                }
                else if (currentState.nameHash == senpai.pose_1)
                {
                    timer_f += Time.deltaTime;
                    timer_i = (int)timer_f;
                    if (player.transform.rotation.y <= -0.7f)
                    {
                        if (player.transform.position.x > -945.35f)
                        {
                            transform.Translate(Vector3.forward * Time.deltaTime * 75);
                        }
                    }
                }
                else if (currentState.nameHash == senpai.pose_5)
                {
                    timer_f += Time.deltaTime;
                    timer_i = (int)timer_f;
                    if (player.transform.rotation.y <= -0.7f)
                    {
                        if (player.transform.position.x > -945.35f)
                        {
                            transform.Translate(Vector3.forward * Time.deltaTime * 75);
                        }
                    }
                }
            }
        }
        if (player.transform.position.x > 820 && timer_ei < 100)
        {
            timer_win += Time.deltaTime;
            timer_wini = (int)timer_win;
            action.animator.SetBool("win", true);
            if (timer_wini == 4)
            {
                progress.HP_Value = 1;
                timer_win = 0;
                timer_e = 0;
                SceneManager.LoadScene(8);
            }
        }
        if (player.transform.position.x > 820 && timer_ei>=100 && timer_ei<135)
        {
            timer_win += Time.deltaTime;
            timer_wini = (int)timer_win;
            action.animator.SetBool("win", true);
            if (timer_wini == 4)
            {
                progress.HP_Value = 1;
                timer_win = 0;
                timer_e = 0;
                SceneManager.LoadScene(6);
            }
        }
        
    }
}
