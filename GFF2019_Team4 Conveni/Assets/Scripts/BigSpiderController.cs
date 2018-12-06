﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSpiderController : MonoBehaviour
{
    public GameObject player;
    public float MoveSpeed = 1;
    


    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        

    }

 
    void Update()
    {

    }


    void OnTriggerStay2D(Collider2D other)　//プレイヤーがコライダー(感知範囲)に入ったかを判断
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log("感知圏内にプレイヤーが入りました。");

            PlayerLook();


            int SPC = Random.Range(0, 150);   //SpiderCount、略してSPC,決してサメを殴る団体ではありません。
            if (SPC == 5)
            {
                speedUP();
            }

        }
    }

    void PlayerLook()  //蜘蛛がプレイヤーの方を向いて動く
    {

        var vec = (player.transform.position - this.transform.position).normalized;
        this.transform.rotation = Quaternion.FromToRotation(Vector3.up, vec);

        transform.Translate(0, 1 * MoveSpeed * Time.deltaTime, 0);

       
      
      
    }


    void speedUP() 
    {
        transform.Translate(0, 3 ,0);
    }
}
