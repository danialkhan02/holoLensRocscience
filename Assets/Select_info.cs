using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select_info : MonoBehaviour
{
    public GameObject[] images;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Whatever(int index){



        for(int i = 0; i<18; i++){

            images[i].SetActive(false);

        }

        images[index].SetActive(true);
    }
}
