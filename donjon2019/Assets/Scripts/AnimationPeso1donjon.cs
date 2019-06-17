using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationPeso1donjon : MonoBehaviour
{
    Animator anim;
    
    void Start()
    {
        anim = GetComponent<Animator>();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            {
            anim.SetBool("laConditionSaut",true);
            }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            anim.SetBool("laConditionSaut", false);
        }
    }
}
