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

        

        ClearCanvas.SetActive(true);
    }
}
