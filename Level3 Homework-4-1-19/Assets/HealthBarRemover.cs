using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarRemover : MonoBehaviour
{
    void Update(){
        if(Input.GetKeyDown(KeyCode.Space))
        {
            HealthBarScript.health -= 10f;
        } 
    }    
}
