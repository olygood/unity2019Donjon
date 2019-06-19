using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRouge : MonoBehaviour
{
    
    void Start()
    {
       
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "cubevert")
        {
            Debug.Log("touche cubevert");
            GameObject.Find("cubevert").GetComponent<CubeVert>().lifeVert -= 1;
        }
        
    }
    void Update()
    {
     
    }
}
