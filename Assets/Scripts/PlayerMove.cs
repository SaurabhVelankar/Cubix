using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMove : MonoBehaviour
{

    public Rigidbody rigidB;
    public float forwardForce = 2000f;
    public float sidewaysforce = 500f;
   
    
    void FixedUpdate()
    {
        rigidB.AddForce(0, 0, forwardForce * Time.deltaTime);

        if( Input.GetKey("d") )
        {
            rigidB.AddForce(sidewaysforce*Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a") )
        {
            rigidB.AddForce(-sidewaysforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(rigidB.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
       
    }
}
