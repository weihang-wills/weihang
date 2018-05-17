using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{

    private Rigidbody2D m_Rigidbody2D;
    public LayerMask PlayerLayer;  //Player作为一个filter过滤出只计算监测碰撞效果的层级
    private Transform ground;
    const float k_GroundedRadius = .2f;




    // Use this for initialization
    void Start()
    {
        m_Rigidbody2D = this.GetComponent<Rigidbody2D>();
        ground = transform.Find("ground");//碰撞监测点

        PlayerLayer = 1 << 8; //1<<N，N就是layer层级号，这里就是说第8层


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            m_Rigidbody2D.velocity = new Vector2(1f, m_Rigidbody2D.velocity.y);//改变速度

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Rigidbody2D.AddForce(new Vector2(0, 300f)); //加一个力
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            m_Rigidbody2D.velocity = new Vector2(-2, m_Rigidbody2D.velocity.y);
        }

        if (Physics2D.OverlapCircle(ground.position, k_GroundedRadius, PlayerLayer))   ////第8层的collider碰撞器才能被检测到
        {
            m_Rigidbody2D.AddForce(new Vector2(0, 200f));
        }
    }
}
