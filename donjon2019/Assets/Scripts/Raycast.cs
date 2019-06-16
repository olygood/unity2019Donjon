using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{

    void Update()
    {
        Debug.DrawRay(transform.position, Vector3.forward * 20, Color.cyan, 1);
        RaycastHit hit;

        if (Physics.Raycast(transform.position, Vector3.forward, out hit))
        {
            if (hit.transform.tag == "enemy1")
            {
                Destroy(hit.transform.gameObject,3.5f);
            }
        }
    }           

}