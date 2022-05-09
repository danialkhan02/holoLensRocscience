using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toggle_script2 : MonoBehaviour
{

    public int status;
    // Start is called before the first frame update
    void Start()
    {
        status = 0;
    }

    // Update is called once per frame
    public void state_change()
    {
        if (status == 0)
        {
            status = 1;
        }
        else
        {
            status = 0;
        }
    }
}
