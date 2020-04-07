using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnitManager : MonoBehaviour
{
    string ignitTag = "Pedestal";

    // Update is called once per frame  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray();
            RaycastHit hit = new RaycastHit();
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            //マウスクリックした場所からRayを飛ばし、オブジェクトがあればtrue 
            if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
            {
                if (hit.collider.gameObject.CompareTag(ignitTag))
                {
                    hit.collider.gameObject.GetComponent<IgnitStatus>().ChangeIgnit();
                }
            }
        }
    }
}