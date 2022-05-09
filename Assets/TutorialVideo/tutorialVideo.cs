using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialVideo : MonoBehaviour
{

    
    public int toggle = 1;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //toggle = gameObject.GetComponentsInChildren<toggle_script>().status;
        if (toggle == 1)
        {
           
            Instantiate(GameObject.FindWithTag("Video"));
                
            
        }
        else
        {
            Destroy(GameObject.FindWithTag("Video"));
            
        }

    }

    public void state_change(int help)
    {
        if (toggle == 0)
        {
            toggle = 1;
        }
        else
        {
            toggle = 0;
        }
    }
}
