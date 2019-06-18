using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRouge : MonoBehaviour
{
    
    void Start()
    {
        GameObject.Find("cubevert").GetComponent<CubeVert>().lifeVert -= 5;
    }

    
    void Update()
    {
        GameObject.Find("cubevert").GetComponent<CubeVert>().lifeVert += 0.01f;
    }
}
