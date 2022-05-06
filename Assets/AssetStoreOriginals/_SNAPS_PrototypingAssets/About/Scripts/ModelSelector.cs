using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ModelSelector : MonoBehaviour
{
    public GameObject[] models;
    public GameObject[] texts;
    // Start is called before the first frame update
    void Start(){
        Destroy(GameObject.FindWithTag("Text"));
        Instantiate(texts[0]);
    }

    void Update(){
        //Destroy(GameObject.FindWithTag("Model"));

        
    }
    public void HandleInputData(int val){
        if(val == 0){
            Destroy(GameObject.FindWithTag("Model"));
            Destroy(GameObject.FindWithTag("Text"));
            Instantiate(texts[0]);
        }
        if(val == 1){
            Destroy(GameObject.FindWithTag("Model"));
            Destroy(GameObject.FindWithTag("Text"));
            Instantiate(models[0]);
            Instantiate(texts[1]);
            
        }
        if(val == 2){
            Destroy(GameObject.FindWithTag("Model"));
            Destroy(GameObject.FindWithTag("Text"));
            Instantiate(models[1]);
            Instantiate(texts[2]);
        }
        if (val == 3){
            Destroy(GameObject.FindWithTag("Model"));
            Destroy(GameObject.FindWithTag("Text"));
            Instantiate(models[2]);
            Instantiate(texts[3]);
        }
        if(val == 4){
            Destroy(GameObject.FindWithTag("Model"));
            Destroy(GameObject.FindWithTag("Text"));
            Instantiate(models[3]);
            Instantiate(texts[4]);
        }
    }
}
