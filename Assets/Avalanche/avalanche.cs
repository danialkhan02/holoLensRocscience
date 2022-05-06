using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avalanche : MonoBehaviour
{

    public GameObject[] rocks;
    public int toggle = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //toggle = gameObject.GetComponentsInChildren<toggle_script>().status;
        if(toggle == 1){
            Instantiate(rocks[0]);
        } else {
            Destroy(GameObject.FindWithTag("Boulder"));
        }
        
    }

    public void state_change(int help)
    {
        if(toggle == 0){
            toggle = 1;
        } else {
            toggle = 0;
        }
    }
}
