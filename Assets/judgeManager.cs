using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class judgeManager : MonoBehaviour {
    int count;
    int trueCount;
    quizManager script;
    GameObject quizM;

	// Use this for initialization
	void Start () {
        count = 0;
        quizM = GameObject.Find("QuizM");
        script = quizM.GetComponent<quizManager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        if ( count== 1)
        {

            script.Quetion2();

        }
        if(count == 2)
        {
            script.Quetion3();


        }

        if(count == 3)
        {
            PlayerPrefs.SetInt("count", trueCount);
            SceneManager.LoadScene("EndScene");


        }

    }


    public void QuetionAnswer()
    {
        count++;
        Debug.Log(count);
        Text selectedBtn = this.GetComponentInChildren<Text>();

        if (selectedBtn.text == "2020年" || selectedBtn.text == "野球" || selectedBtn.text == "カレー" )
        {

            trueCount++;
            Debug.Log("正解");
           



        }
        else
        {
            Debug.Log("不正解");
           

        }
    }
}

