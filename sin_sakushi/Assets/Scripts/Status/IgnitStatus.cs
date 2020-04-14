using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnitStatus : MonoBehaviour
{
    [SerializeField]
    bool ignit;
    
    //炎のサイズ 0:無 1:小 2:中 3:大
    int fireSize;
    
    // Start is called before the first frame update
    void Start()
    {
        ignit = false;
        fireSize = 0;
    }
    

    public bool GetIgnit()
    {
        return ignit;
    }

    public void ChangeIgnit()
    {
        ignit = !ignit;
        SetFireSize(2);
    }

    public void SetIgnit(bool ign)
    {
        ignit = ign;
    }

    /// <summary>
    /// 炎の大きさの獲得
    /// </summary>
    public int GetFireSize()
    {
        return fireSize;
    }

    /// <summary>
    /// 炎の大きさの設定
    /// </summary>
    /// <param name="setFire">0:消 1:小 2:中 3:大</param>
    public void SetFireSize(int setFire)
    {
        fireSize = setFire;
        if (fireSize < 0)
        {
            fireSize = 0;
        }
        else if (fireSize > 3)
        {
            fireSize = 3;
        }
    }
}
