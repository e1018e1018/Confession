using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class progress : MonoBehaviour {
    public Slider slider;
    public Transform LoadingBar;
    public Image HP;
    public static float HP_Value = 1;
    float timer_f = 0f;
    float timer_c = 0f;
    public GameObject player,trigger;
    bool checkMouse=true;
    float speed = 30;
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        HP.fillAmount=HP_Value;
        AnimatorStateInfo currentState = senpai.animator.GetCurrentAnimatorStateInfo(0);
        float x = ((trigger.transform.position.x - player.transform.position.x) / 1.76615f) / 1000;
        slider.value = 1 - x;
        if (currentState.nameHash == senpai.pose_1 || currentState.nameHash == senpai.pose_5)
        {
            timer_f += Time.deltaTime;
        }
        if (currentState.nameHash == senpai.pose_1)
        {
            if (timer_f >= 3f && timer_f <= 5.5f)
            {
                if (Input.GetMouseButtonUp(0) || player.transform.position.y >= 0.7f)
                {
                    checkMouse = true;
                    
                }
                if (Input.GetMouseButton(0))
                {
                    checkMouse = false;
                }
                while (checkMouse == false)
                {
                    timer_c +=  Time.deltaTime;
                    HP_Value = HP_Value - (0.025f * timer_c);
                    checkMouse = true;
                }
            }
        }
        if (currentState.nameHash == senpai.pose_5)
        {
            if (timer_f >= 7f && timer_f <= 11f)
            {
                if (Input.GetMouseButtonUp(0) || player.transform.position.y >= 0.7f)
                {
                    checkMouse = true;

                }
                if (Input.GetMouseButton(0))
                {
                    checkMouse = false;
                }
                while (checkMouse == false)
                {
                    timer_c += Time.deltaTime;
                    HP_Value = HP_Value - (0.025f * timer_c);
                    checkMouse = true;
                }
            }
        }
        if (currentState.nameHash == senpai.pose_0)
        {
            timer_f = 0;
            timer_c = 0;
        }
    }
    }