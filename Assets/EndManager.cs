using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndManager : MonoBehaviour {
    int lastScore;
    public Text text;

	// Use this for initialization
	void Start () {
        lastScore = PlayerPrefs.GetInt("count");
        text.text = lastScore.ToString();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
