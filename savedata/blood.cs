using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LitJson;

public class blood : MonoBehaviour {
    //血条扣减和扣血淡出动画

    public Slider slider;
    private int bloodline;
    public GameObject blooddecline;
    



	// Use this for initialization
	void Start () {

        bloodline = 100;
        blooddecline.SetActive(false);
        

        


	}
	
	// Update is called once per frame
	void Update () {

        slider.value = bloodline/100f;
		
	}
    public void savedata()
    {
        persondata person = new persondata();
        person.shengming = bloodline;//存值进去
        person.lingqi = 50;
        save.savedate(person);
    }
    public void Loaddatas()
    {
        
        save save1 = new save();//实例化一个save类用来取本地的值
        save1.Loaddata();        
        bloodline = save1.person.shengming;//取此时的persondata类里面的值
        Debug.Log(bloodline);
    }
    public void Onclickbutton()
    {
        if (bloodline > 0)
        {
            bloodline = bloodline - 10;
            blooddecline.SetActive(true);
            Component[] comps = blooddecline.GetComponentsInChildren<Component>();//局部变量
            foreach (Component c in comps)
                            {
                if (c is Graphic)
                {
                    (c as Graphic).CrossFadeAlpha(0, 1, true); //只针对graphic才能有这个淡出效果，（目标alpha，淡出时间，bool)
                }
                
            }
            

        }

        

    }
}
