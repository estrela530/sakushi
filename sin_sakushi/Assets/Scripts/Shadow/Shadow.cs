using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    [SerializeField] GameObject Shadow1;
    [SerializeField] GameObject Shadow2;
    [SerializeField] GameObject Shadow3;
    [SerializeField] GameObject Shadow4;
    [SerializeField] ModeManager modeManager;
    [SerializeField] IgnitStatus ignitStatus;
    [SerializeField] int SetShadow1;
    [SerializeField] int SetShadow2;
    [SerializeField] int SetShadow3;
    [SerializeField] int SetShadow4;

    private void Start()
    {
        Shadow1.gameObject.SetActive(false);
        Shadow2.gameObject.SetActive(false);
        Shadow3.gameObject.SetActive(false);
        Shadow4.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!ignitStatus.GetIgnit())
        {
            Shadow1.gameObject.SetActive(false);
            Shadow2.gameObject.SetActive(false);
            Shadow3.gameObject.SetActive(false);
            Shadow4.gameObject.SetActive(false);
            return;
        }
        //影1の出現
        if (modeManager.NowOutMode() == SetShadow1)
        {
            //着火の時
            //中が1
            if (modeManager.NowInMode() == 1)
            {
                Shadow1.gameObject.SetActive(true);
                Shadow2.gameObject.SetActive(false);
                Shadow3.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
            }
            //中が2
            else if (modeManager.NowInMode() == 2)
            {
                Debug.Log("aa");
                Shadow4.gameObject.SetActive(true);
                Shadow1.gameObject.SetActive(false);
                Shadow2.gameObject.SetActive(false);
                Shadow3.gameObject.SetActive(false);
            }
            //中が3
            else if (modeManager.NowInMode() == 3)
            {
                Shadow3.gameObject.SetActive(true);
                Shadow1.gameObject.SetActive(false);
                Shadow2.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
            }
            //中が4
            else if (modeManager.NowInMode() == 4)
            {
                Shadow2.gameObject.SetActive(true);
                Shadow3.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
                Shadow1.gameObject.SetActive(false);
            }
        }
        //影2の出現
        else if (modeManager.NowOutMode() == SetShadow2)
        {
            //着火の時
            //中が1
            if (modeManager.NowInMode() == 1)
            {
                Shadow2.gameObject.SetActive(true);
                Shadow3.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
                Shadow1.gameObject.SetActive(false);
            }
            //中が2
            else if (modeManager.NowInMode() == 2)
            {
                Shadow1.gameObject.SetActive(true);
                Shadow2.gameObject.SetActive(false);
                Shadow3.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
            }
            //中が3
            else if (modeManager.NowInMode() == 3)
            {
                Shadow4.gameObject.SetActive(true);
                Shadow1.gameObject.SetActive(false);
                Shadow2.gameObject.SetActive(false);
                Shadow3.gameObject.SetActive(false);
            }
            //中が4
            else if (modeManager.NowInMode() == 4)
            {
                Shadow3.gameObject.SetActive(true);
                Shadow1.gameObject.SetActive(false);
                Shadow2.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
            }
        }
        //影3の出現
        else if (modeManager.NowOutMode() == SetShadow3)
        {
            //着火の時
            //中が1
            if (modeManager.NowInMode() == 1)
            {
                Shadow3.gameObject.SetActive(true);
                Shadow1.gameObject.SetActive(false);
                Shadow2.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
            }
            //中が2
            else if (modeManager.NowInMode() == 2)
            {
                Shadow2.gameObject.SetActive(true);
                Shadow3.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
                Shadow1.gameObject.SetActive(false);
            }
            //中が3
            else if (modeManager.NowInMode() == 3)
            {
                Shadow1.gameObject.SetActive(true);
                Shadow2.gameObject.SetActive(false);
                Shadow3.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
            }
            //中が4
            else if (modeManager.NowInMode() == 4)
            {
                Shadow4.gameObject.SetActive(true);
                Shadow1.gameObject.SetActive(false);
                Shadow2.gameObject.SetActive(false);
                Shadow3.gameObject.SetActive(false);
            }
        }
        //影4の出現
        else if (modeManager.NowOutMode() == SetShadow4)
        {
            //着火の時
            //中が1
            if (modeManager.NowInMode() == 1)
            {
                Shadow4.gameObject.SetActive(true);
                Shadow1.gameObject.SetActive(false);
                Shadow2.gameObject.SetActive(false);
                Shadow3.gameObject.SetActive(false);
            }
            //中が2
            else if (modeManager.NowInMode() == 2)
            {
                Shadow3.gameObject.SetActive(true);
                Shadow1.gameObject.SetActive(false);
                Shadow2.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
            }
            //中が3
            else if (modeManager.NowInMode() == 3)
            {
                Shadow2.gameObject.SetActive(true);
                Shadow3.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
                Shadow1.gameObject.SetActive(false);
            }
            //中が4
            else if (modeManager.NowInMode() == 4)
            {
                Shadow1.gameObject.SetActive(true);
                Shadow2.gameObject.SetActive(false);
                Shadow3.gameObject.SetActive(false);
                Shadow4.gameObject.SetActive(false);
            }
        }

    }
}
