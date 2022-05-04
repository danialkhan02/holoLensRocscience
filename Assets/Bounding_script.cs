using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounding_script : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        double current_pos = transform.position.y;

        if(current_pos <= -4){
            transform.position = new Vector3(-2,2,1);
            rb.velocity = new Vector3(0,0,0);
        }
    }
}
