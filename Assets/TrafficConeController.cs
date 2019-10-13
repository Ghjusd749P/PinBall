using UnityEngine;
using System.Collections;

public class TrafficConeController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < this.unitychan.transform.position.z)
        {
            Destroy(this.gameObject);
        }
    }
}