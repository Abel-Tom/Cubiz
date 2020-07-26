using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
   public float X;
    public float Y;
    public float Z;
 GameObject SpherePrefab;
    
    void Start()
    {
        SpherePrefab = Resources.Load("Sphere") as GameObject;
    }

  
    void FixedUpdate()
    {

        if (Input.GetMouseButton(1))
        {
            Y += 0.1f;
        }
        else if(Input.GetMouseButtonUp(1))
        {
            Y = 0f;
        }

        if (Input.GetMouseButton(0))
        {
            Z += -0.1f;
            Debug.Log(Z);
            
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Debug.Log("Z: " +  Z);
            if(Z != 0f && Y != 0f)
                {
                GameObject projectile = Instantiate(SpherePrefab) as GameObject;
                projectile.transform.position = transform.position + Camera.main.transform.forward * 2;
                Rigidbody rb = projectile.GetComponent<Rigidbody>();
                rb.velocity = new Vector3(X, Y, Z);
                Z = 0f;
            }
            Z = 0f;
            
        }

       
    }

   
}
