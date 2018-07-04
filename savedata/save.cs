using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;
using LitJson;

public class persondata
{     //数据列表类
    public int shengming;
    public int lingqi;

}
public class save{



    public persondata person = new persondata();


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Loaddata()
    {
        string filepath = Application.dataPath + @"/persondata/persondata.json";
        Debug.Log(Application.dataPath + @"/persondata/persondata.json");

        if (!File.Exists(filepath))
        {
            Debug.Log("no file");
            return;
        }

        StreamReader sr = new StreamReader(filepath);

        
        string dataset = sr.ReadToEnd();//取值
        Debug.Log(dataset);

        person = JsonMapper.ToObject<persondata>(dataset);//toobject赋值给persondata类
        
        
        

    }
    public static void savedate(persondata data)
    {
        string filepath = Application.dataPath + @"/persondata/persondata.json";
        Debug.Log(Application.dataPath + @"/persondata/persondata.json");

        string json = JsonMapper.ToJson(data);//persondata类传值进来，转为json数据保存
        Debug.Log(json);

        FileInfo file = new FileInfo(filepath);
        StreamWriter sw = file.CreateText();
        sw.WriteLine(json);
        sw.Close();
        sw.Dispose();
        AssetDatabase.Refresh();

    }
    
}
