using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_script : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void state_change(int status)
    {
        if(status == 0){
            status = 1;
        } else {
            status = 0;
        }
    }
}
