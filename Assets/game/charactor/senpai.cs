using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class senpai : MonoBehaviour {
    public static Animator animator;
    public static int pose_0 = Animator.StringToHash("Base Layer.00");               //pose zero
    public static int pose_1 = Animator.StringToHash("Base Layer.01");              //pose one
    public static int pose_2 = Animator.StringToHash("Base Layer.02");              //pose two
    public static int pose_3 = Animator.StringToHash("Base Layer.03");              //pose three
    public static int pose_4 = Animator.StringToHash("Base Layer.04");              //pose four
    public static int pose_5 = Animator.StringToHash("Base Layer.05");              //pose five
    float nt;                                                                       //counter
    // Use this for initialization
    void Start () {
        animator = GetComponent<Animator>();  
    }
	
	// Update is called once per frame
	void Update () {
        AnimatorStateInfo currentState = animator.GetCurrentAnimatorStateInfo(0);   //get current pose
        float sec = Random.Range(10, 15);                                           //set time range             
        nt= nt + Time.deltaTime/sec;
        if (nt > 0.5f)                                                              //if time>0.5sec
        {
            int i = Random.Range(0, 6);                                             //set range 0 to 5
            animator.SetInteger("pose", i);                                         //set the pose randomly with value 0 to 5 
            nt = 0;                                                                 //time return 0
        }
    }
}
