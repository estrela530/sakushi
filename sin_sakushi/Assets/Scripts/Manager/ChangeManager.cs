using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeManager : MonoBehaviour
{
    [SerializeField, Header("外周部の親オブジェクト")]
    OutCameraRotate outRotate;
    [SerializeField, Header("中心部の親オブジェクト")]
    InCameraRotate inRotate;

    [SerializeField]
    ModeManager modeManager;

    // Start is called before the first frame update
    void Start()
    {
        outRotate.enabled = true;
        inRotate.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            outRotate.enabled = !outRotate.enabled;
            inRotate.enabled = !inRotate.enabled;

            modeManager.ChangeInOut();
        }
    }
}
