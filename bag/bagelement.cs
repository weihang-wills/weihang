using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class bagelement : MonoBehaviour {

    public GameObject bagelementprefab;

    public int lianzi2;
    public int binglu2;
    public int fenghuangyu2;
    public int niuyangjinya2;

    //public Transform panel;
	// Use this for initialization
	
    void Start () {

        loadon();
        


        //GameObject bagelement = Instantiate(bagelementprefab,transform);//instantiate的参数有好几套，这里的transform代表this.transform
        //bagelement.transform.SetParent(transform);
        //bagelement.transform.localScale = new Vector3(99.92509f, 99.92509f, 99.92509f);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void savaon()
    {


    }

    public void loadon(){
        bagdata bagdata = new bagdata();
        bagdata.loadbagdata();

        lianzi2 = bagdata.bag_Data.lianzi;
        binglu2 = bagdata.bag_Data.binglu;
        fenghuangyu2 = bagdata.bag_Data.fenghuangyu;
        niuyangjinya2 = bagdata.bag_Data.niuyangjinya;

        if (lianzi2>0)
        {
            GameObject lianzi = Instantiate(bagelementprefab, transform);//复制一个prefab
            SpriteRenderer sr = lianzi.GetComponent<SpriteRenderer>();
            Sprite s = Resources.Load("bag/莲子",typeof(Sprite)) as Sprite;
            sr.sprite = s;//给复制出来的sprite配图
            lianzi.transform.localScale = new Vector3(99.92509f, 99.92509f, 99.92509f);
            lianzi.name="莲子";//给复制出来的sprite改名字
            GameObject text = GameObject.Find("莲子/Text");//找到这个sprite下的text，给text赋值
            Text texture = text.GetComponent<Text>();
            texture.text = lianzi2.ToString();
        }
        if (binglu2>0)
        {
            GameObject binglu = Instantiate(bagelementprefab, transform);
            SpriteRenderer sr = binglu.GetComponent<SpriteRenderer>();
            Sprite s = Resources.Load("bag/冰露", typeof(Sprite)) as Sprite;
            sr.sprite = s;
            binglu.transform.localScale = new Vector3(99.92509f, 99.92509f, 99.92509f);
            binglu.name = "冰露";
            GameObject text = GameObject.Find("冰露/Text");
            Text texture = text.GetComponent<Text>();
            texture.text = binglu2.ToString();
        }
        if (fenghuangyu2>0)
        {
            GameObject fenghuangyu = Instantiate(bagelementprefab, transform);
            SpriteRenderer sr = fenghuangyu.GetComponent<SpriteRenderer>();
            Sprite s = Resources.Load("bag/凤凰羽", typeof(Sprite)) as Sprite;
            sr.sprite = s;
            fenghuangyu.transform.localScale = new Vector3(99.92509f, 99.92509f, 99.92509f);
            fenghuangyu.name = "凤凰羽";
            GameObject text = GameObject.Find("凤凰羽/Text");
            Text texture = text.GetComponent<Text>();
            texture.text = fenghuangyu2.ToString();
        }
        if (niuyangjinya2>0)
        {
            GameObject niuyangjinya = Instantiate(bagelementprefab, transform);
            SpriteRenderer sr = niuyangjinya.GetComponent<SpriteRenderer>();
            Sprite s = Resources.Load("bag/钮阳金牙", typeof(Sprite)) as Sprite;
            sr.sprite = s;
            niuyangjinya.transform.localScale = new Vector3(99.92509f, 99.92509f, 99.92509f);
            niuyangjinya.name = "钮阳金牙";
            GameObject text = GameObject.Find("钮阳金牙/Text");
            Text texture = text.GetComponent<Text>();
            texture.text = niuyangjinya2.ToString();
        }



    }
}
