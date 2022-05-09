using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mini_Boulder : MonoBehaviour
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
            Destroy (this.gameObject);
        }
    }

    Vector3 RandomVector() {

        float rand1= Random.value;
        float negative = (Mathf.Round(Random.value*10) %2) * (-1);
        if(negative ==0){
            rand1 = rand1 *0.5f;
        } else {
            rand1 = rand1 * (-0.5f);
        }
        float rand2= Random.value;
        rand2 = rand2 /6;

        float rand3= Random.value;
        negative = (Mathf.Round(Random.value*10) %2) * (-1);
        if(negative ==0){
            rand3 = rand3 *0.5f;
        } else {
            rand3 = rand3 * (-0.5f);
        }

        return new Vector3(rand1,rand2,rand3);
    }

}
