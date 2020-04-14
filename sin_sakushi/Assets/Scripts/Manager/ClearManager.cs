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

    [SerializeField, Header("クリアのための内外の差分の数字(例:内1の外3がクリア例だったら2を入れる)")]
    int clearNum;

    // Start is called before the first frame update
    void Start()
    {
        ClearCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //着いてるべきところが着いているか
        for (int i = 0; i < FirePedestals.Count; i++)
        {
            if (!FirePedestals[i].GetIgnit())
            {
                ClearCanvas.SetActive(false);
                return;
            }
        }

        //消えてるべきところが消えてるか
        for (int i = 0; i < ClearPedestals.Count; i++)
        {
            if (ClearPedestals[i].GetIgnit())
            {
                ClearCanvas.SetActive(false);
                return;
            }
        }

        //外のクリアの設定
        int clear = modeManager.NowInMode() + clearNum;
        if (clear > 4)
        {
            clear -= 4;
        }
        //内外のクリアの判定
        switch (modeManager.NowInMode())
        {
            case 1:
                if(modeManager.NowOutMode() != clear)
                {
                    ClearCanvas.SetActive(false);
                    return;
                }
                break;
            case 2:
                if (modeManager.NowOutMode() != clear)
                {
                    ClearCanvas.SetActive(false);
                    return;
                }
                break;
            case 3:
                if (modeManager.NowOutMode() != clear)
                {
                    ClearCanvas.SetActive(false);
                    return;
                }
                break;
            case 4:
                if (modeManager.NowOutMode() != clear)
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
