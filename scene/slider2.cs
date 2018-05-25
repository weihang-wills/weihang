using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class slider2 : MonoBehaviour {   //对比slider.cs中的写法，进度条更加平滑

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
        operation.allowSceneActivation = false;
                
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
            operation.allowSceneActivation = true;

        }
       
        		
	}
}
