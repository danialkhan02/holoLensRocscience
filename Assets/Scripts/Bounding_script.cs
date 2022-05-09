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
        //rb.velocity = RandomVector(); Don't want initial velocity for large boulders

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

        float rand1= Random.value;
        rand1 = rand1 *( ((Random.value*10)%2 )*2 -1);
        rand1 = rand1 / 3;
        float rand2= Random.value;
        rand2 = rand2 *( ((Random.value*10)%2 )*2 -1);
        rand2 = rand2 /3;
        float rand3= Random.value;
        rand3 = rand3 *( ((Random.value*10)%2 )*2 -1);
        rand3 = rand3/3;

        return new Vector3(rand1,rand2,rand3);
    }

}
