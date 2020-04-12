using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearManager : MonoBehaviour
{
    [SerializeField,Header("着火状態でクリアの台座のリスト")]
    List<IgnitStatus> FirePedestals;

    [SerializeField, Header("鎮火状態でクリアの台座のリスト")]
    List<IgnitStatus> ClearPedestals;

    [SerializeField,Header("クリア関係のCanvas")]
    GameObject ClearCanvas;

    [SerializeField, Header("モードマネージャー")]
    ModeManager modeManager;

    // Start is called before the first frame update
    void Start()
    {
        ClearCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < FirePedestals.Count; i++)
        {
            if (!FirePedestals[i].GetIgnit())
            {
                ClearCanvas.SetActive(false);
                return;
            }
        }

        
        for (int i = 0; i < ClearPedestals.Count; i++)
        {
            if (ClearPedestals[i].GetIgnit())
            {
                ClearCanvas.SetActive(false);
                return;
            }
        }

        switch (modeManager.NowInMode())
        {
            case 1:
                if(modeManager.NowOutMode() != 3)
                {
                    ClearCanvas.SetActive(false);
                    return;
                }
                break;
            case 2:
                if (modeManager.NowOutMode() != 4)
                {
                    ClearCanvas.SetActive(false);
                    return;
                }
                break;
            case 3:
                if (modeManager.NowOutMode() != 1)
                {
                    ClearCanvas.SetActive(false);
                    return;
                }
                break;
            case 4:
                if (modeManager.NowOutMode() != 2)
                {
                    ClearCanvas.SetActive(false);
                    return;
                }
                break;
            default:
                break;
        }

        ClearCanvas.SetActive(true);
    }
}
