using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowerdrop : MonoBehaviour {

    public Animator flowersdrop;
    public GameObject flower;


	// Use this for initialization
	void Start () {
        
        
    }
	
	// Update is called once per frame
	void Update () {
        AnimatorStateInfo info = flowersdrop.GetCurrentAnimatorStateInfo(0);
        if (info.normalizedTime >= 1.0f)
        {
            flower.SetActive(false);
            Invoke("bofang",20f);
        }
        
		
	}

    void bofang()
    {
        flower.SetActive(true);

        /*flowersdrop.Play("flowerdrop",0，normalizedTime);
        flowersdrop.enabled = true;*/


        float recordtime = flowersdrop.playbackTime;//记录一个进度时间点
        flowersdrop.StartPlayback();//在这个进度时间点停下来（相当于暂停）

        flowersdrop.StopPlayback();//退出这个模式（继续播放）

        

        






    


    }
}
