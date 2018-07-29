using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class plot : MonoBehaviour {

    public GameObject laidao;
    public GameObject xixiang;
    public GameObject kuaikaile;
    public GameObject shangchuan;
    public GameObject jiaban;
    public GameObject dujiang;
    public GameObject snake;
    int i;

    // Use this for initialization
    void Start()
    {
        i = 0;
        laidao.SetActive(true);
        GameObject[] all = { xixiang, kuaikaile, shangchuan, jiaban, dujiang };
        foreach(GameObject i in all)
        {
            i.SetActive(false);
        }
        SpriteRenderer ren = snake.GetComponent<SpriteRenderer>();
        Color c = ren.material.color;
        c.a = 0f;
        ren.material.color = c;

    }

    
	
	// Update is called once per frame
	void Update () {

        SpriteRenderer ren = snake.GetComponent<SpriteRenderer>();
        Color c = ren.material.color;
        Color b = ren.material.color;
        c.a = 1f;


        if (dujiang.activeSelf==true)
        {
            
            ren.material.color = Color.Lerp(b, c, Mathf.Clamp01(1.2f * Time.deltaTime));
        }
        if (jiaban.activeSelf == true)
        {
            dujiang.SetActive(true);
        }

    }


    public void Clickon()
    {
        GameObject[] all={laidao, kuaikaile, xixiang, shangchuan, jiaban };

        if (i > 3)
        {

            new map().fightscene(1);
            return;

        }
        
            
        
            if (all[i].activeSelf == true)
            {
                all[i].SetActive(false);
                all[i+1].SetActive(true);
            i++;

            }

            


    }
}
