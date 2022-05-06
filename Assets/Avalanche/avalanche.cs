using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avalanche : MonoBehaviour
{

    public GameObject[] rocks;
    public int toggle = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //GetComponentsInChildren<
        if(toggle == 1){
            Instantiate(rocks[0]);
        } else {
            Destroy(GameObject.FindWithTag("Boulder"));
        }
        
    }
}
