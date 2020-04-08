using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ignition : MonoBehaviour
{
    IgnitStatus status;
    [SerializeField]
    Material fireMat;
    [SerializeField]
    Material normalMat;

    

    private void Start()
    {
        status = gameObject.GetComponent<IgnitStatus>();
    }

    // Update is called once per frame  
    void Update()
    {
        //着火状態
        if (status.GetIgnit())
        {
            GetComponent<Renderer>().material = fireMat;
            
        }//鎮火状態
        else
        {
            GetComponent<Renderer>().material = normalMat;
        }
    }
}
