using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed = 1000;
    public float Atack = 5000;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        GetComponent<Rigidbody>().AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Speed * Time.fixedDeltaTime, ForceMode.Acceleration);
        if(Input.GetButtonDown("Fire1")) 
        {
            GetComponent<Rigidbody>().AddForce(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")) * Atack, ForceMode.Impulse);
        }
    }
}
