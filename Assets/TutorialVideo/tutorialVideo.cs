using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialVideo : MonoBehaviour
{

    
    public int toggle = 0;
    public GameObject[] canvas;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        //toggle = gameObject.GetComponentsInChildren<toggle_script>().status;
        

    }

    public void state_change(int help)
    {
        print("CHANGE");
        if (toggle == 0)
        {
            canvas[0].SetActive(true);

            toggle = 1;
            
        }
        else
        {
            canvas[0].SetActive(false);
            toggle = 0;
            
        }
    }
}
