using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class JudgeManager : MonoBehaviour {
    int quizCount;
    int trueCount;
    QuizManager script;
    GameObject quizM;
   

    // Use this for initialization
    void Start () {
        quizCount = 0;
        quizM = GameObject.Find("QuizM");
        script = quizM.GetComponent<QuizManager>();
    }

    // Update is called once per frame
    void Update()
    {



        switch (quizCount)
        {
            case 1:
                script.Quetion2();
                break;
            case 2:
                script.Quetion3();
                break;
            case 3:
                PlayerPrefs.SetInt("count", trueCount);
                SceneManager.LoadScene("EndScene");
                break;



        }



    }
    public void QuetionAnswer1()
    {
       Text selectedBtn = GameObject.Find("Button1").GetComponentInChildren<Text>();


        if (selectedBtn.text == "2020年" || selectedBtn.text == "野球" || selectedBtn.text == "カレー")
        {

            trueCount++;
            Debug.Log("正解");

        }
        else
        {
            Debug.Log("不正解");

        }

        quizCount++;
        Debug.Log(quizCount);
    }

    public void QuetionAnswer2()
    {
      Text  selectedBtn = GameObject.Find("Button2").GetComponentInChildren<Text>();


        if (selectedBtn.text == "2020年" || selectedBtn.text == "野球" || selectedBtn.text == "カレー" )
        {

            trueCount++;
            Debug.Log("正解");

        }
        else
        {
            Debug.Log("不正解");
           
        }

        quizCount++;
        Debug.Log(quizCount);
    }
    public void QuetionAnswer3()
    {
      Text  selectedBtn = GameObject.Find("Button3").GetComponentInChildren<Text>();


        if (selectedBtn.text == "2020年" || selectedBtn.text == "野球" || selectedBtn.text == "カレー")
        {

            trueCount++;
            Debug.Log("正解");

        }
        else
        {
            Debug.Log("不正解");

        }

        quizCount++;
        Debug.Log(quizCount);
    }

    public void QuetionAnswer4()
    {
      Text  selectedBtn = GameObject.Find("Button4").GetComponentInChildren<Text>();


        if (selectedBtn.text == "2020年" || selectedBtn.text == "野球" || selectedBtn.text == "カレー")
        {

            trueCount++;
            Debug.Log("正解");

        }
        else
        {
            Debug.Log("不正解");

        }

        quizCount++;
        Debug.Log(quizCount);
    }
}

