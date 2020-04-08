using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    [SerializeField] GameObject Shadow1;
    [SerializeField] GameObject Shadow2;
    [SerializeField] ModeManager modeManager;
    [SerializeField] IgnitStatus ignitStatus;
    [SerializeField] int SetShadow1;
    [SerializeField] int SetShadow2;


    private void Start()
    {
        Shadow1.gameObject.SetActive(false);
        Shadow2.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //影1の出現
        if (modeManager.NowOutMode() == SetShadow1 && ignitStatus.GetIgnit())
        {
            //着火の時
            Shadow1.gameObject.SetActive(true);
        }
        else
        {
            Shadow1.gameObject.SetActive(false);
        }
        //影2の出現
        if (modeManager.NowOutMode() == SetShadow2 && ignitStatus.GetIgnit())
        {
            //鎮火の時
            Shadow2.gameObject.SetActive(true);
        }
        else
        {
            Shadow2.gameObject.SetActive(false);
        }


    }
}
