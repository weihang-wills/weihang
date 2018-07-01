using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour {

    /*跳台游戏的代码*/

    public GameObject master;
    
    private GameObject platform2;
    
    private Rigidbody2D m_rigid;
    private bool move;
    private int num;

    // Use this for initialization
    void Start () {
        num = 1;
        platform2 = GameObject.Find("矩形" + num);
        
        m_rigid = master.GetComponent<Rigidbody2D>();
        move = false;
        

    }
	
	// Update is called once per frame
	void Update () {

        

        if (Input.GetKeyDown(KeyCode.D))
        {
            Transform trans = master.GetComponent<Transform>();
           
            Transform targettrans2 = platform2.GetComponent<Transform>();
            
            m_rigid.AddForce(new Vector2(0, 150f));
            move = true;
            num++;
            Debug.Log(num);

            
        }

        if (move == true)
        {
            platform2 = GameObject.Find("矩形" + num);
            Transform trans = master.GetComponent<Transform>();
            
            Transform targettrans2 = platform2.GetComponent<Transform>();
                        
            
            if (trans.position !=targettrans2.position )
            {
                float speed = 0;
                speed += Time.deltaTime * 5f;
                float journey = Vector3.Distance(trans.position, targettrans2.position);
                float t = speed / journey;
                trans.position = Vector3.Lerp(trans.position, targettrans2.position, t);

            }
            else
            {
                move = false;
            }
            
        }

        



    }
    
}
