using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    [SerializeField] GameObject Shadow1;
    [SerializeField] GameObject Shadow2;
    [SerializeField] GameObject gai;//外周部
    [SerializeField] GameObject tyu;//中心部
    [SerializeField] ModeManager modeManager;
    [SerializeField] IgnitStatus ignitStatus;
    [SerializeField] int Oshadw1;
    [SerializeField] int Ishadw1;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //影1の出現
        if (modeManager.NowOutMode() == Oshadw1 && ignitStatus.GetIgnit())
        {
            //着火の時
            Shadow1.gameObject.SetActive(true);
        }
        else
        {
            Shadow1.gameObject.SetActive(false);
        }
        //影2の出現
        if (modeManager.NowInMode() == Ishadw1 && !ignitStatus.GetIgnit())
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
