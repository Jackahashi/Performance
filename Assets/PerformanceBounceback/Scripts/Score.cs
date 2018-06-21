using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;

    public Text Scoretext;

	// Use this for initialization
	void Start () {
        gameManager = gameManager.GetComponent<GameManager>();
        Text text = GetComponentInChildren<Text>();
        UpdateTheScore();
       
    }
	
	
	public void UpdateTheScore () {

        Scoretext.text = "Score: " + gameManager.score.ToString();

	}

  
}
