using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeManager : MonoBehaviour
{
    [SerializeField]
    OutCameraRotate outRotate;
    [SerializeField]
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
