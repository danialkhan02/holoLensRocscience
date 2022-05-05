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

        if(current_pos <= -20){
            transform.position = new Vector3(1.7f,6f,-9f);
            rb.velocity = new Vector3(0,0,0);
        }
    }
}
