using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destruction());
    }

  
    IEnumerator Destruction()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }


    // Update is called once per frame
    void Update()
    {
      
    }
}
