using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnitStatus : MonoBehaviour
{
    [SerializeField]
    bool ignit;
    // Start is called before the first frame update
    void Start()
    {
        ignit = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetIgnit()
    {
        return ignit;
    }

    public void ChangeIgnit()
    {
        ignit = !ignit;
    }
}
