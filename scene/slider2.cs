using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class slider2 : MonoBehaviour {   

    public Slider m_slider;
    private AsyncOperation operation;
    
    private uint nowprocess=0;
    private uint toprocess;




    //全局的异步加载场景方法
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(Loadscene(sceneIndex));//启动异步协程
    }
    
    //定义一个协程，int变量需要手动输入
    IEnumerator Loadscene(int sceneIndex)
    {
        operation = SceneManager.LoadSceneAsync(sceneIndex);
        operation.allowSceneActivation = false;//加载完成不立刻切换过去，而是等待进度条完成再切换，这比slider.cs中的进度条要平滑

        yield return operation;


    }


	// Use this for initialization
	void Start () {
        


		
	}
	
	// Update is called once per frame
	void Update () {

       
        if (operation.progress < 0.9f)
        {
            toprocess = (uint)(operation.progress * 100);


        }
        else
        {
            toprocess = 100;

        }

        if (nowprocess < toprocess)
        {
            nowprocess++;

        }

        m_slider.value = nowprocess / 100f;


        if (nowprocess == 100)
        {
            operation.allowSceneActivation = true;//加载完成不立刻切换过去，而是等待进度条完成再切换

        }
       
        		
	}
}
