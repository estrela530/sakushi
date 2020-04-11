using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InOutMaterial : MonoBehaviour
{
    [SerializeField]
    Transform outParent;

    [SerializeField]
    Transform inParent;

    [SerializeField]
    ModeManager modeManager;

    [SerializeField]
    Material operateMat;

    [SerializeField]
    Material notOperateMat;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (modeManager.GetFalseInTrueOut())
        {
            foreach (Transform child in outParent)
            {
                if (child.gameObject.tag == "Block")
                {
                    child.gameObject.GetComponent<Renderer>().material = operateMat;
                }
            }

            foreach (Transform child in inParent)
            {
                child.gameObject.GetComponent<Renderer>().material = notOperateMat;
            }
        }
        else if (!modeManager.GetFalseInTrueOut())
        {
            foreach (Transform child in inParent)
            {
                child.gameObject.GetComponent<Renderer>().material = operateMat;
            }

            foreach (Transform child in outParent)
            {
                if (child.gameObject.tag == "Block")
                {
                    child.gameObject.GetComponent<Renderer>().material = notOperateMat;
                }
            }
        }
    }
}
