using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour {
    //血条扣减和扣血淡出动画

    public Slider slider;
    private uint bloodline;
    public GameObject blooddecline;
    private Text test;
    public GameObject target;
    
    private bool move;
    private Vector3 vv;



    // Use this for initialization
    void Start () {

        bloodline = 100;
        test = blooddecline.GetComponent<Text>();
        move = false;
        test.CrossFadeAlpha(0, 0, true);//初始透明度
        Transform trans = blooddecline.GetComponent<Transform>();
        vv = trans.position;//获取初始位置
 
    }
	
	// Update is called once per frame
	void Update () {
        slider.value = bloodline / 100f;

        if (move ==true) { 
        Transform trans = blooddecline.GetComponent<Transform>();

         trans.Translate(new Vector3(1, 2, 0) * 0.1f * Time.deltaTime);//方向*速度*delta时间，此方法只在void update下有效



           /* float distcovered = Time.deltaTime * 1f;
            Transform trans = blooddecline.GetComponent<Transform>();
            Transform targettrans = target.GetComponent<Transform>();
            float journeylength = Vector3.Distance(trans.position, targettrans.position);
            float frcjourney = distcovered / journeylength;
            trans.position = Vector3.Lerp(trans.position, targettrans.position, frcjourney);
         采用另一种方法来位移，distcovered是行进路程，journeylength是总路程,vector3.lerp就是通过在起点和终点连线进行插值   
         */  
        }
        else
        {
            Transform trans = blooddecline.GetComponent<Transform>();
            trans.position = vv;//传值回原点
        }


    }
    public void Onclickbutton()
    {
        


        if (bloodline > 0)
        {
            move = true;
            Invoke("movebool", 0.5f);//延时0.5s执行movebool

            bloodline = bloodline - 10;
            
            test.CrossFadeAlpha(100, 0, true);

            Component[] comps = blooddecline.GetComponentsInChildren<Component>();//局部变量
            foreach (Component c in comps)
                            {
                if (c is Graphic)
                {
                  (c as Graphic).CrossFadeAlpha(0, duration: 5/10f, ignoreTimeScale: false); //只针对graphic才能有这个淡出效果，（目标alpha，淡出时间，bool)
                }

            }

        }

    }
    void movebool()
    {
        move = false;
    }
}
