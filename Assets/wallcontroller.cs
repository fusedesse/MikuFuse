using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallController : MonoBehaviour
{
    public float speed = 0.01f;

    private void Move() //壁の移動に関するメソッド
    {
        //右へ移動
        transform.Translate(this.speed, 0, 0);

        //右端まで来たら向きを反転
        if (this.transform.position.x >= 9.5f)
        {
            this.speed = -this.speed;
            Debug.Log("left");
        }

        //左端まで来たら向きを反転
        if (this.transform.position.x <= -9.5f)
        {
            this.speed = -this.speed;
            Debug.Log("right");
        }
    }

    void Start()
    {
        Debug.Log("Start");
    }

    void Update()
    {
        Move();
    }
}