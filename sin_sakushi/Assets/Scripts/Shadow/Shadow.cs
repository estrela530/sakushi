using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    [SerializeField] GameObject Shadow1;
    [SerializeField] GameObject Shadow2;
    [SerializeField] GameObject Shadow3;
    [SerializeField] GameObject Shadow4;
    [SerializeField] GameObject gai;//外周部
    [SerializeField] GameObject tyu;//中心部
    [SerializeField] ModeManager modeManager;
    [SerializeField] IgnitStatus ignitStatus;
    [SerializeField] int Oshadw1;
    [SerializeField] int Ishadw1;

    //[SerializeField] float ShadowSizeX;//影のサイズX
    //[SerializeField] float ShadowSizeY;//影のサイズY
    //[SerializeField] float ShadowSizeZ;//影のサイズZ
    //[SerializeField] int SizeMul;//倍する値
    //[SerializeField] int SizeDiv;//割る値
    //int a;//代用

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

        //影3の出現
        if (modeManager.NowOutMode() == Oshadw1 && ignitStatus.GetIgnit())
        {
            //着火の時
            Shadow3.gameObject.SetActive(true);
        }
        else
        {
            Shadow3.gameObject.SetActive(false);
        }

        //影4の出現
        if (modeManager.NowInMode() == Ishadw1 && !ignitStatus.GetIgnit())
        {
            //鎮火の時
            Shadow4.gameObject.SetActive(true);
        }
        else
        {
            Shadow4.gameObject.SetActive(false);
        }
        //ShadowSize();
    }
    //void ShadowSize()
    //{
    //    //Shadow1が出現中
    //    if (Shadow1)
    //    {
    //       switch(a)
    //       {
    //           //標準
    //           case 1:
    //               Shadow1.transform.localScale = new Vector3(ShadowSizeX, ShadowSizeY, ShadowSizeZ);
    //               break;
    //           //倍
    //           case 2:
    //               Shadow1.transform.localScale = new Vector3(ShadowSizeX* SizeMul, ShadowSizeY* SizeMul, ShadowSizeZ* SizeMul);
    //               break;
    //           //小さく
    //           case 3:
    //               Shadow1.transform.localScale = new Vector3(ShadowSizeX / SizeDiv, ShadowSizeY / SizeDiv, ShadowSizeZ / SizeDiv);
    //               break;
    //       }
    //    }
    //    if (Shadow2)
    //    {
    //         switch(a)
    //       {
    //           //標準
    //           case 1:
    //               Shadow1.transform.localScale = new Vector3(ShadowSizeX, ShadowSizeY, ShadowSizeZ);
    //               break;
    //           //倍
    //           case 2:
    //               Shadow1.transform.localScale = new Vector3(ShadowSizeX* SizeMul, ShadowSizeY* SizeMul, ShadowSizeZ* SizeMul);
    //               break;
    //           //小さく
    //           case 3:
    //               Shadow1.transform.localScale = new Vector3(ShadowSizeX / SizeDiv, ShadowSizeY / SizeDiv, ShadowSizeZ / SizeDiv);
    //               break;
    //       }
    //    }
    //}
}
