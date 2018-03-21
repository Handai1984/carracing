using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Rigidbody2D m_rigid;
    public float speed=5;

    private Vector3 prepos;
    private Vector3 curretpos;
    private bool isMouseDown = false;
    private float endpos;



    private void Start()
    {
        m_rigid = this.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        m_rigid.velocity = Vector2.up * speed * Time.fixedDeltaTime;

    }

    private void Update()
    {
        //    if (Input.GetMouseButton(0))
        //    {
        //        ///获取按下的时刻的鼠标世界位置
        //        Vector3 mouse = Input.mousePosition;
        //        mouse.z = 0f;
        //        prepos = Camera.main.ScreenToWorldPoint(mouse);
        //        isMouseDown = true;   
        //    }
        //    else
        //    {
        //        isMouseDown = false;
        //    }
        //    if (isMouseDown)
        //    {
        //        ///获取当前鼠标的世界坐标位置
        //        Vector3 mouse = Input.mousePosition;
        //        print("当前鼠标位置"+mouse);
        //        mouse.z = 0f;
        //        curretpos = Camera.main.ScreenToWorldPoint(mouse);
        //        ///取得之前和先向量的差
        //        float  newPos = Vector3.Angle(prepos, curretpos);
        //        endpos = newPos;
        //        transform.Rotate(0, 0, endpos);
        //        prepos = curretpos;

        //    }
        //}
        //if (Input.GetMouseButton(0))
        //{

        //    Vector3 aimPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y));//目标位置 .  
        //    Vector3 dir = (aimPos - transform.position).normalized; //方向.  

        //    Quaternion targetRotation = Quaternion.LookRotation(dir, Vector3.up);
        //    Quaternion newRotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * Time.deltaTime);
        //    m_rigid.MoveRotation(newRotation.z);


        //    if (Vector3.Distance(aimPos, transform.position) > 0.1f)
        //    {
        //        m_rigid.MovePosition(dir * Time.fixedDeltaTime * 5 + transform.position);
        //    }
        //}
    }
}
