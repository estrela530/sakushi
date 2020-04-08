using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnitStatus : MonoBehaviour
{
    [SerializeField]
    bool ignit;

    Ray ray;//今はつかってないよ
    RaycastHit hit;//I don't use now
    public GameObject fire;//台座のx軸の直線状にあるやつ
    public GameObject gai;//外回り見てるよ
    
    // Start is called before the first frame update
    void Start()
    {
        ignit = false;
        ray = new Ray(transform.position, transform.forward);
    }

    // Update is called once per frame
    void Update()
    {
        if(ignit)
        {
            if (Physics.Raycast(ray, out hit, 160.0f)) 
            {
                hit.collider.GetComponent<MeshRenderer>().material.color = Color.red;
                Debug.DrawRay(transform.position, transform.forward * 160.0f, Color.yellow);
            }
        }
    }

    public bool GetIgnit()
    {
        return ignit;
        //GetComponent<BoxCollider>().enabled = true;
    }

    public void ChangeIgnit()
    {
        ignit = !ignit;
    }
}
