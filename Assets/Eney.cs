using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eney : MonoBehaviour
{
    public int Hp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        var rigid = collision.body.GetComponent<Rigidbody>();
        if (rigid != null)
            if (rigid.velocity.magnitude > 5)
                Hp--;
        if (Hp <= 0)
            Destroy(gameObject);
    }
}
