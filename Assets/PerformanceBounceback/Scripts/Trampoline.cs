using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour {

    public ParticleSystem pSystem;
    public GameManager scoreScript;
    public Score scoreBoard;
  

	void Start () {
        scoreScript = scoreScript.GetComponent<GameManager>();
        pSystem = GetComponentInChildren<ParticleSystem>();   
    }
	
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.CompareTag("Throwable"))
        {
           
            scoreScript.score++;
            pSystem.Play();
            scoreBoard.UpdateTheScore();



        }

    }
}
