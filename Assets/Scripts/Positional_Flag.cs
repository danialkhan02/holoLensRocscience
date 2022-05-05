using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positional_Flag : MonoBehaviour
{

    public int table_flag;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        double z_pos = transform.position.z;
        double x_pos = transform.position.x;

        if(x_pos >=-3.5f && x_pos <= 0.5f && z_pos <=3.3){
            table_flag = 1;
        } else {
            table_flag = 0;
        }
        
    }
}
