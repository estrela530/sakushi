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
        if (modeManager.NowOutMode()== 2)
        {
            //外周部が90度の時に出現
            Shadow1.gameObject.SetActive(true);
        }
        else
        {
            Shadow1.gameObject.SetActive(false);
        }
        //影2の出現
        if (modeManager.NowInMode() == 3)
        {
            //中心部が180度の時に出現
            Shadow2.gameObject.SetActive(true);
        }
        else
        {
            Shadow2.gameObject.SetActive(false);
        }

    }
}
