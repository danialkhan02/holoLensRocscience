using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainfall : MonoBehaviour
{
    public int toggle = 0;
    public GameObject rain_fall;

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
            rain_fall.SetActive(true);

            toggle = 1;
            
        }
        else
        {
            rain_fall.SetActive(false);
            toggle = 0;
            
        }
    }
}
