using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadow : MonoBehaviour
{
    public GameObject Shadow1;
    public GameObject Shadow2;
    public GameObject gai;//外周部
    public GameObject tyu;//中心部
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //影1の出現
        if (gai.transform.rotation.y == 0)
        {
            Shadow1.gameObject.SetActive(true);
        }
        else
        {
            Shadow1.gameObject.SetActive(false);
        }
        //影2の出現
        if (gai.transform.rotation.y == 180)
        {
            Shadow2.gameObject.SetActive(true);
        }
        else
        {
            Shadow2.gameObject.SetActive(false);
        }


    }
}
