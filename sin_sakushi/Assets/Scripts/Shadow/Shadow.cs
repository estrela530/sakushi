using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    [SerializeField] GameObject Shadow1;
    [SerializeField] GameObject Shadow2;
    public GameObject gai;//外周部
    public GameObject tyu;//中心部
    [SerializeField] ModeManager modeManager;
    [SerializeField] int Osha1;//影1の出現条件
    [SerializeField] int Isha2;//影2の出現条件
    [SerializeField] IgnitStatus ignitStatus;

    // Start is called before the first frame update
    void Start()
    { 
        
    }

    // Update is called once per frame
    void Update()
    {
        if (modeManager == null)
        {
            return;
        }
        //影1の出現
        if (modeManager.NowOutMode()== Osha1 && ignitStatus.GetIgnit())
        {
            //着火してる時に
            //外周部が0度の時   1
            //外周部が90度の時  2
            //外周部が180度の時 3
            //外周部が-90度の時 4
            Shadow1.gameObject.SetActive(true);
        }
        else
        {
            Shadow1.gameObject.SetActive(false);
        }
        //影2の出現
        if (modeManager.NowInMode() == Isha2 && !ignitStatus.GetIgnit())
        {
            //鎮火してる時に
            //中心部が0度の時   1
            //中心部が90度の時  2
            //中心部が180度の時 3
            //中心部が-90度の時 4
            Shadow2.gameObject.SetActive(true);
        }
        else
        {
            Shadow2.gameObject.SetActive(false);
        }

    }
}
