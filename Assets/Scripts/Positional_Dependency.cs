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
            transform.position = new Vector3(-0.55f,0.89f,-3.77f);
        } else {
            transform.position = new Vector3(-1000,-1000,-1000);
        }
    }
}
