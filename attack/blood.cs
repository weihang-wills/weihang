using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class blood : MonoBehaviour {
    //血条扣减和扣血淡出动画

    public Slider slider;
    private uint bloodline;
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
