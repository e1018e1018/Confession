using UnityEngine;
using UnityEngine.SceneManagement;

public class action : MonoBehaviour
{
    public static Animator animator;
    Quaternion targetRotation;
    float timer_f = 0f;
    float timer_e = 0f;
    int timer_i = 0;
    public AudioClip impact;
    public AudioSource audio;
    void Start()
    {
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
    }
    void Update()
    {
        AnimatorStateInfo currentState = senpai.animator.GetCurrentAnimatorStateInfo(0);
        if (currentState.nameHash == senpai.pose_1 || currentState.nameHash == senpai.pose_5)
        {
            timer_f += Time.deltaTime;
            //print(timer_f);
        }
        if (Input.GetMouseButton(0))
        {
            if (animator.GetBool("over") == false)
            {
                if (currentState.nameHash == senpai.pose_3 || currentState.nameHash == senpai.pose_4 || currentState.nameHash == senpai.pose_2)
                {
                    targetRotation = Quaternion.Euler(0f, 90f, 0f);
                    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10);
                    animator.SetBool("walk", true);
                    animator.SetBool("run", false);
                    animator.SetBool("stop", false);
                }

                if (currentState.nameHash == senpai.pose_1)
                {
                    if (timer_f >= 3f && timer_f <= 5.5f)
                    {
                        targetRotation = Quaternion.Euler(0f, -90f, 0f);
                        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 30);
                        animator.SetBool("run", true);
                        animator.SetBool("walk", false);
                        animator.SetBool("stop", false);
                    }
                    else
                    {
                        targetRotation = Quaternion.Euler(0f, 90f, 0f);
                        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10);
                        animator.SetBool("walk", true);
                        animator.SetBool("run", false);
                        animator.SetBool("stop", false);
                    }
                }
                if (currentState.nameHash == senpai.pose_5)
                {
                    if (timer_f >= 7f && timer_f <= 11f)
                    {
                        targetRotation = Quaternion.Euler(0f, -90f, 0f);
                        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 30);
                        animator.SetBool("run", true);
                        animator.SetBool("walk", false);
                        animator.SetBool("stop", false);
                    }
                    else
                    {
                        targetRotation = Quaternion.Euler(0f, 90f, 0f);
                        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10);
                        animator.SetBool("walk", true);
                        animator.SetBool("run", false);
                        animator.SetBool("stop", false);
                    }
                }
                if (currentState.nameHash == senpai.pose_0)
                {
                    timer_f = 0;
                    targetRotation = Quaternion.Euler(0f, 90f, 0f);
                    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 10);
                    animator.SetBool("walk", true);
                    animator.SetBool("run", false);
                    animator.SetBool("stop", false);
                }
            }
        }
        if (progress.HP_Value <= 0)
        {
            timer_e += Time.deltaTime;
            timer_i = (int)timer_e;
            animator.SetBool("over", true);
            animator.SetBool("walk", false);
            animator.SetBool("run", false);
            animator.SetBool("stop", false);
            if (timer_i == 6)
            {
                progress.HP_Value = 1;
                timer_e = 0;
                SceneManager.LoadScene(5);
            }
        }
        if (action.animator.GetBool("over") == true)
        {
            audio.PlayOneShot(impact, 1);
        }

        if (Input.anyKey!=true)
        {
            animator.SetBool("stop", true);
            animator.SetBool("walk", false);
            animator.SetBool("run", false);
        }
    }
    void Sound()
    {
        if (progress.HP_Value <= 0)
        {

        }
    }
}