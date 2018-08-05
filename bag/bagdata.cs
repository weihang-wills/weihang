using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LitJson;
using System.IO;
using UnityEditor;

public class bag_data
{
    public int lianzi;
    public int binglu;
    public int fenghuangyu;
    public int niuyangjinya;

}

public class bagdata {

    public bag_data bag_Data;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void savebagdata(bag_data bag_Data)
    {
        string filepath = Application.dataPath + @"/characterdata/bagdata.json";
        Debug.Log(filepath);

        string bagdata = JsonMapper.ToJson(bag_Data);
        Debug.Log(bagdata);

        FileInfo file = new FileInfo(filepath);
        StreamWriter sw = new StreamWriter(filepath);//试一下

        sw.WriteLine(bagdata);
        sw.Close();
        sw.Dispose();
        AssetDatabase.Refresh();

    }
    public void loadbagdata()
    {
        string filepath = Application.dataPath + @"/characterdata/bagdata.json";
        Debug.Log(filepath);

        if (!File.Exists(filepath))
        {
            Debug.Log("no file");
            return;
        }
        StreamReader sr = new StreamReader(filepath);
        string dataset = sr.ReadToEnd();
        Debug.Log(dataset);
        bag_Data = JsonMapper.ToObject<bag_data>(dataset);

    }
}
