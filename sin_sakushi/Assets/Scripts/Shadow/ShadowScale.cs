﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowScale : MonoBehaviour
{
    Shadow sha;
    [SerializeField] GameObject Shadow1;
    [SerializeField] GameObject Shadow2;
    [SerializeField] float ShadowSizeX;//影のサイズX
    [SerializeField] float ShadowSizeY;//影のサイズY
    [SerializeField] float ShadowSizeZ;//影のサイズZ
    [SerializeField] int SizeMul;//倍する値
    [SerializeField] int SizeDiv;//割る値
    int a;//代用

    // Start is called before the first frame update
    void Start()
    {
        a = 1;
    }

    // Update is called once per frame
    void Update()
    {
        //デバッグ用
        if (Input.GetKeyDown(KeyCode.Z))
        {
            a = 1;//標準
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            a = 2;//倍
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            a = 3; //小さく
        }
        ShaScale();
    }

    void ShaScale()
    {
        //Shadow1が出現中
        if (Shadow1)
        {
            switch(a)
            {
                //標準
                case 1:
                    Shadow1.transform.localScale = new Vector3(ShadowSizeX, ShadowSizeY, ShadowSizeZ);
                    break;
                //倍
                case 2:
                    Shadow1.transform.localScale = new Vector3(ShadowSizeX * SizeMul, ShadowSizeY * SizeMul, ShadowSizeZ * SizeMul);
                    break;
                //小さく
                case 3:
                    Shadow1.transform.localScale = new Vector3(ShadowSizeX / SizeDiv, ShadowSizeY / SizeDiv, ShadowSizeZ / SizeDiv);
                    break;
            }
           
        }
        //Shadow2が出現中
        if (Shadow2)
        {
            switch (a)
            {
                //標準
                case 1:
                    Shadow2.transform.localScale = new Vector3(ShadowSizeX, ShadowSizeY, ShadowSizeZ);
                    break;
                //倍
                case 2:
                    Shadow2.transform.localScale = new Vector3(ShadowSizeX * SizeMul, ShadowSizeY * SizeMul, ShadowSizeZ * SizeMul);
                    break;
                //小さく
                case 3:
                    Shadow2.transform.localScale = new Vector3(ShadowSizeX / SizeDiv, ShadowSizeY / SizeDiv, ShadowSizeZ / SizeDiv);
                    break;
            }
        }
    }
}
