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

        if(x_pos >=-2f && x_pos <= 1.1f && z_pos <=-0.65f){
            table_flag = 1;
        } else {
            table_flag = 0;
        }
        
    }
}
