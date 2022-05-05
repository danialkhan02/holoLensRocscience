using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Positional_Dependency : MonoBehaviour
{
    int table = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        table = gameObject.GetComponentInParent<Positional_Flag>().table_flag;

        if (table ==1){
            transform.position = new Vector3(-0.44f,0.6f,-4.77f);
        } else {
            transform.position = new Vector3(-1000,-1000,-1000);
        }
    }
}
