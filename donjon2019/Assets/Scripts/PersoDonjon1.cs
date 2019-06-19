using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersoDonjon1 : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("je touche le cube rouge : " + col.gameObject.tag);
        if(col.gameObject.tag == "Player")
        {
            GameObject.Find("player").GetComponent<Perso>().life -= 3;
        }
       
    }
 

  
    void Update()
    {
        
    }
}
