﻿using UnityEngine;
using System.Collections;

public class CoinController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    // Use this for initialization
    void Start()
    {
        //回転を開始する角度を設定
        this.transform.Rotate(0, Random.Range(0, 360), 0);
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //回転
        this.transform.Rotate(0, 3, 0);
        if (this.transform.position.z < this.unitychan.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}