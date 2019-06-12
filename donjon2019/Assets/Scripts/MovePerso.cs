using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePerso : MonoBehaviour
{
    public int speed = 3;
    public int acceleration = 20;
    void Start()
    {


    }


    void Update()
    {
        /* vitesse directe getKey
        if (Input.GetKey(KeyCode.UpArrow)) 
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

    */

        // vitesse plus souple getAxis
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * v * Time.deltaTime * speed);
        transform.Translate(Vector3.right * h * Time.deltaTime * speed);

        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.forward * v * Time.deltaTime * acceleration);
            transform.Translate(Vector3.right * h * Time.deltaTime * acceleration);
        }
    }
    
}


// même chose
// transform.translate(new vector3(0;0,1));
// transform.translate(Vector3.forward);
