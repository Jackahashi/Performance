using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground")){
            gameObject.SetActive(false);
        }
   

    }

}