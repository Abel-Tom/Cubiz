using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float X;
    public float Y;
    public float Z;
    Rigidbody rb;
    void Start()
    {

      

        Vector3 force = new Vector3(X, Y, Z);

       rb = GetComponent<Rigidbody>();
        rb.AddForce(X, Y, Z);
    }
  

  
       
    
   
}
