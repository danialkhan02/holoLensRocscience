using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockCollision : MonoBehaviour
{
    void OnCollisionEnter (Collision col)
    {
        if(col.collider.tag == "Model"){
            FindObjectOfType<AudioManager>().Play("RockSound");
        }
    }
}
