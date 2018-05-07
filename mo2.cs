using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mo2 : MonoBehaviour
{

    public Animator hahaha;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
          hahaha.SetBool("dianji", true);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            hahaha.SetBool("haha", true);

        }
        


        

    }
}


		
	

