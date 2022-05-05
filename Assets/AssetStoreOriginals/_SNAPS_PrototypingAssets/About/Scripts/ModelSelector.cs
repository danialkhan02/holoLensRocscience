using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ModelSelector : MonoBehaviour
{
    public GameObject[] models;
    // Start is called before the first frame update

    void Update(){
        //Destroy(GameObject.FindWithTag("Model"));

        
    }
    public void HandleInputData(int val){
        if(val == 0){

        }
        if(val == 1){
            Destroy(GameObject.FindWithTag("Model"));
            Instantiate(models[0]);
            
        }
        if(val == 2){
            Destroy(GameObject.FindWithTag("Model"));
            Instantiate(models[1]);
        }
        if (val == 3){
            Destroy(GameObject.FindWithTag("Model"));
            Instantiate(models[2]);
        }
    }
}
