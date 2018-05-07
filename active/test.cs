using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class test : MonoBehaviour
{

    public GameObject Gd;
    public GameObject Fd;



    // Use this for initialization
    void Start()
    {
        Gd = GameObject.Find("Canvas 2");
        Fd = GameObject.Find("Canvas");


        Gd.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {

    }

    void Onclick()
    {

        Gd.SetActive(true);
        Fd.SetActive(false);

    }

    void Scene()
    {

        SceneManager.LoadScene(5);


    }
}