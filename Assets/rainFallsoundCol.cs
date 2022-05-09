using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rainFallsoundCol : MonoBehaviour
{
    void OnCollisionEnterRain (Collision col)
    {
        if(col.collider.tag == "Model"){
            FindObjectOfType<AudioManager>().Play("RockSound");
        }
    }
}
