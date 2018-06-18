using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour {
    //血条扣减和扣血淡出动画

    public Slider slider;
    public Slider shengming;
    public Slider lingqi;
    private int bloodline;
    private int shengmingline;
    private int lingqiline;
    public GameObject blooddecline;
    public GameObject baoji;
    public GameObject baojikouxue;
    private Text test;
    private Text test1;
    public GameObject shengli;
    
        
    private bool move;
    private bool move1;
    private Vector3 vv;
    private Vector3 vv1;





    // Use this for initialization
    void Start () {

        shengli.SetActive(false);
        //baoji.SetActive(false);
        bloodline = 100;
        shengmingline = 100;
        lingqiline = 100;

         
        



        test = blooddecline.GetComponent<Text>();
        test1 = baojikouxue.GetComponent<Text>();
        move = false;
        move1 = false;
        test.CrossFadeAlpha(0, 0, true);//初始透明度
        test1.CrossFadeAlpha(0, 0, true);
        

        Transform trans = blooddecline.GetComponent<Transform>();
        vv = trans.position;//获取初始位置

        Transform trans1 =baojikouxue.GetComponent<Transform>();
        vv1 = trans1.position;

         
    


    }
	
	// Update is called once per frame
	void Update () {

        slider.value = bloodline /100f;
        shengming.value = shengmingline/100f;
        lingqi.value = lingqiline/100f;

        if (move ==true) { 
        Transform trans = blooddecline.GetComponent<Transform>();

         trans.Translate(new Vector3(1, 3, 0) * 0.1f * Time.deltaTime);//方向*速度*delta时间，此方法只在void update下有效

          
        }
        else
        {
            Transform trans = blooddecline.GetComponent<Transform>();
            trans.position = vv;//传值回原点
        }

        if (move1 == true)
        {
            Transform trans1 = baojikouxue.GetComponent<Transform>();

            trans1.Translate(new Vector3(1, 3, 0) * 0.1f * Time.deltaTime);//方向*速度*delta时间，此方法只在void update下有效

            SpriteRenderer ren = baoji.GetComponent<SpriteRenderer>();
            Color c = ren.material.color;
            Color b = ren.material.color;

            c.a = 1f;
            b.a = 0f;
            float m = Mathf.Clamp(0.3f * Time.deltaTime, 0f, 1.0f);
            ren.material.color = Color.Lerp(c, b, m);
            
           
        }
        else
        {
            Transform trans1 = baojikouxue.GetComponent<Transform>();
            trans1.position = vv1;//传值回原点

            //做color赋值初始化
            SpriteRenderer ren = baoji.GetComponent<SpriteRenderer>();
            Color c = ren.material.color;
            c.a = 0f;
            ren.material.color = c;
        }

        if (bloodline <= 0)
        {
            shengli.SetActive(true);
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

            /*Component[] comps = blooddecline.GetComponentsInChildren<Component>();//局部变量
            foreach (Component c in comps)
                            {
                if (c is Graphic)
                {
                  (c as Graphic).CrossFadeAlpha(0, duration: 5/10f, ignoreTimeScale: false); //只针对graphic才能有这个淡出效果，（目标alpha，淡出时间，bool)
                }

            

               
                
               


            }*/
            test.CrossFadeAlpha(0, 0.5f, true);


        }



    }
    public void Onclickbutton1()
    {



        if (bloodline > 0)
        {
            /*baoji.SetActive(true);
            Invoke("baojimove", 0.3f);*/

            move1 = true;
            Invoke("movebool1", 0.5f);//延时0.5s执行movebool


            


            
            


            bloodline = bloodline - 30;

            test1.CrossFadeAlpha(100, 0, true);

            Component[] comps = baojikouxue.GetComponentsInChildren<Component>();//局部变量
            foreach (Component c in comps)
            {
                if (c is Graphic)
                {
                    (c as Graphic).CrossFadeAlpha(0, duration: 5 / 10f, ignoreTimeScale: false); //只针对graphic才能有这个淡出效果，（目标alpha，淡出时间，bool)
                }


            }
            
        }
       

    }
    void movebool()
    {
        move = false;
    }
    void movebool1()
    {
        move1 = false;
    }
    void baojimove()
    {
        baoji.SetActive(false);
    }
    public void huifuxuetiao()
    {
        bloodline = 100;
    }
}
