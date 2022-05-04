using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounding_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double current_pos = transform.position.y;

        if(current_pos <= -4){
            transform.position = new Vector3(-2,2,1);
        }
    }
}
