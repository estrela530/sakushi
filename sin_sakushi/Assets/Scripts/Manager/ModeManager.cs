using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModeManager : MonoBehaviour
{
    //true = out false = in
    bool tOutFIn;

    [SerializeField]
    int outMode;

    [SerializeField]
    int inMode;

    //Right = 1  Left = 2
    int setRigLef;

    // Start is called before the first frame update
    void Start()
    {
        tOutFIn = true;
        outMode = 1;
        inMode = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (tOutFIn)
        {
            OutModeChange();
        }
        else
        {
            InModeChange();
        }
    }

    void OutModeChange()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            switch (outMode)
            {
                case 1:
                    outMode = 2;
                    break;
                case 2:
                    outMode = 3;
                    break;
                case 3:
                    outMode = 4;
                    break;
                case 4:
                    outMode = 1;
                    break;
                default:
                    break;
            }
            setRigLef = 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            switch (outMode)
            {
                case 1:
                    outMode = 4;
                    break;
                case 2:
                    outMode = 1;
                    break;
                case 3:
                    outMode = 2;
                    break;
                case 4:
                    outMode = 3;
                    break;
                default:
                    break;
            }

            setRigLef = 2;
        }
    }

    void InModeChange()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            switch (inMode)
            {
                case 1:
                    inMode = 2;
                    break;
                case 2:
                    inMode = 3;
                    break;
                case 3:
                    inMode = 4;
                    break;
                case 4:
                    inMode = 1;
                    break;
                default:
                    break;
            }
            setRigLef = 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            switch (inMode)
            {
                case 1:
                    inMode = 4;
                    break;
                case 2:
                    inMode = 1;
                    break;
                case 3:
                    inMode = 2;
                    break;
                case 4:
                    inMode = 3;
                    break;
                default:
                    break;
            }

            setRigLef = 2;
        }
    }

    public int NowOutMode()
    {
        return outMode;
    }

    public int NowInMode()
    {
        return inMode;
    }

    public int GetRight1Left2()
    {
        return setRigLef;
    }

    public void ChangeInOut()
    {
        tOutFIn = !tOutFIn;
    }
}
