using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ModelSelector : MonoBehaviour
{
    public GameObject[] models;
    public GameObject[] texts;
    public GameObject[] appBar;
    public GameObject[] arrows;

    // Start is called before the first frame update
    void Start(){
        Destroy(GameObject.FindWithTag("Text"));
        Instantiate(texts[0]);
       
    }

    public void HandleInputData(int val){
        if(val == 0){
            models[0].SetActive(false);
            models[1].SetActive(false);
            models[2].SetActive(false);
            models[3].SetActive(false);

            appBar[0].SetActive(false);
            appBar[1].SetActive(false);
            appBar[2].SetActive(false);
            appBar[3].SetActive(false);

            arrows[1].SetActive(false);
            arrows[2].SetActive(false);
            arrows[3].SetActive(false);
            arrows[4].SetActive(false);

            Destroy(GameObject.FindWithTag("Text"));
            Instantiate(texts[0]);
           
        }
        if(val == 1){
            models[1].SetActive(false);
            models[2].SetActive(false);
            models[3].SetActive(false);

            arrows[1].SetActive(false);
            arrows[2].SetActive(false);
            arrows[3].SetActive(false);

            appBar[1].SetActive(false);
            appBar[2].SetActive(false);
            appBar[3].SetActive(false);
            Destroy(GameObject.FindWithTag("Text"));

            models[0].SetActive(true);
            models[0].transform.position = new Vector3(-0.188f,-0.592f,1.564f);
            appBar[0].SetActive(true);
            arrows[0].SetActive(true);

            Instantiate(texts[1]);
            
        }
        if(val == 2){
            models[0].SetActive(false);
            models[2].SetActive(false);
            models[3].SetActive(false);

            appBar[0].SetActive(false);
            appBar[2].SetActive(false);
            appBar[3].SetActive(false);

            arrows[0].SetActive(false);
            arrows[2].SetActive(false);
            arrows[3].SetActive(false);

            Destroy(GameObject.FindWithTag("Text"));
            models[1].SetActive(true);
            models[1].transform.position = new Vector3(-0.188f,-0.592f,1.564f);
            appBar[1].SetActive(true);
            arrows[1].SetActive(true);
            Instantiate(texts[2]);
        }
        if (val == 3){
            models[0].SetActive(false);
            models[1].SetActive(false);
            models[3].SetActive(false);

            appBar[0].SetActive(false);
            appBar[1].SetActive(false);
            appBar[3].SetActive(false);

            arrows[0].SetActive(false);
            arrows[1].SetActive(false);
            arrows[3].SetActive(false);
            Destroy(GameObject.FindWithTag("Text"));

            models[2].SetActive(true);
            models[2].transform.position = new Vector3(-0.188f,-0.592f,1.564f);
            appBar[2].SetActive(true);
            arrows[2].SetActive(true);
            Instantiate(texts[3]);
        }
        if(val == 4){
            models[0].SetActive(false);
            models[1].SetActive(false);
            models[2].SetActive(false);

            appBar[0].SetActive(false);
            appBar[1].SetActive(false);
            appBar[2].SetActive(false);

            arrows[0].SetActive(false);
            arrows[1].SetActive(false);
            arrows[2].SetActive(false);


            Destroy(GameObject.FindWithTag("Text"));
            
            models[3].SetActive(true);
            models[3].transform.position = new Vector3(-0.188f,-0.592f,1.564f);
            appBar[3].SetActive(true);
            arrows[3].SetActive(true);
            Instantiate(texts[4]);



        }
    }
}
