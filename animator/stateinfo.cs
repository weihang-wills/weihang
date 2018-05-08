using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class stateinfo: MonoBehaviour
{
    public Animator hahaha;
    
    public AnimatorStateInfo anistate;


    void Start ()
	{

        hahaha = this.GetComponent<Animator>();



    }
    void Update()
    {
        //持续获取动画机的状态
        anistate = hahaha.GetCurrentAnimatorStateInfo(0);

        //bool值，是否在该状态下
        if (anistate.IsName("Base Layer.hey"))  
        {
            //float值，归一化时间是否大于1.0,1代表第几次循环，小数部分代表该次循环里面的百分比
            if (anistate.normalizedTime >= 1.0f)

                //随便do something
                hahaha.SetBool("lala", true);  

                  }
    }
}
