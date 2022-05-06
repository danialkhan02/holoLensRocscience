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
        rb.velocity = RandomVector();

    }

    // Update is called once per frame
    void Update()
    {
        double current_pos = transform.position.y;

        if(current_pos <= -20){
            transform.position = new Vector3(-0.395f,0.32f,-1.194f);
            rb.velocity = new Vector3(0,0,0);
        }
    }

    Vector3 RandomVector() {
        return new Vector3(Random.value,Random.value, Random.value);
    }

}
