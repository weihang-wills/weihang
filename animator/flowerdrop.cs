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
            Invoke("bofang",5f);
        }
        
		
	}

    void bofang()
    {
        flower.SetActive(true);

        /*
        flowersdrop.enabled = false;  动画机的开启/关闭状态
        flowersdrop.enabled = true;
        flowersdrop.Play("flowerdrop",0,0.8f);Play(string "动画状态",int layer（动画状态所在层）,float normalizedTime）  */















    }
}
