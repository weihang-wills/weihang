using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class slider : MonoBehaviour {

    public Slider m_slider;
    private AsyncOperation operation;
    private float progress;


    //全局的异步加载场景方法
    public void LoadLevel(int sceneIndex)
    {
        StartCoroutine(Loadscene(sceneIndex));//启动异步协程
    }
    
    //定义一个协程，int变量需要手动输入
    IEnumerator Loadscene(int sceneIndex)
    {
        operation = SceneManager.LoadSceneAsync(sceneIndex);
        
        yield return operation;


    }


	// Use this for initialization
	void Start () {
        


		
	}
	
	// Update is called once per frame
	void Update () {

        if (operation.isDone == false)
        {
            progress = Mathf.Clamp01(operation.progress / 0.9f);   //progress取值区间，最大值为0.9f,为加载成功

            m_slider.value = progress;


        }
        		
	}
}
