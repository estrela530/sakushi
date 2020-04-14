using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignition : MonoBehaviour
{
    IgnitStatus status;
    [SerializeField,Header("中サイズの炎のマテリアル")]
    Material fireMat;
    [SerializeField]
    Material normalMat;

    [SerializeField, Header("小サイズの炎のマテリアル")]
    Material smallFireMat;
    [SerializeField, Header("大サイズの炎のマテリアル")]
    Material bigFireMat;

    private void Start()
    {
        status = gameObject.GetComponent<IgnitStatus>();
    }

    // Update is called once per frame  
    void Update()
    {
        //着火状態小炎
        if (status.GetIgnit() && status.GetFireSize() == 1)
        {
            GetComponent<Renderer>().material = smallFireMat;
            
        }//中炎
        else if (status.GetIgnit() && status.GetFireSize() == 2)
        {
            GetComponent<Renderer>().material = fireMat;

        }//大炎
        else if (status.GetIgnit() && status.GetFireSize() == 3)
        {
            GetComponent<Renderer>().material = bigFireMat;

        }
        //鎮火状態
        else
        {
            GetComponent<Renderer>().material = normalMat;
        }
    }
}
