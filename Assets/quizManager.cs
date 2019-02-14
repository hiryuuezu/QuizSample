using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    string[,] quizDate;
    public Text buttonText;
    public Text text;
    int quizCount;
    int trueCount;
    GameObject quizM;
    //基本理念：くりかえしはさける
    //=>もしなんどもこぴぺしているなとかんじたら、まとめられないか考える。
    //つねにインデントは揃える => {}の位置がわからなくなる。
    //空白行も無駄に増やさない。



    // Use this for initialization
    void Start()
    {
        quizCount = 0;

        quizM = GameObject.Find("QuizM");
        Quetion1();

    }

    // Update is called once per frame
    void Update()
    {
        switch (quizCount)
        {
            case 1:
                Quetion2();
                break;
            case 2:
                Quetion3();
                break;
            case 3:
                PlayerPrefs.SetInt("count", trueCount);
                SceneManager.LoadScene("EndScene");
                break;
        }
    }

    public void Quetion1()
    {
        quizDate = csvManager.ReadCsvFile("CSV/quiz");
        text.text = quizDate[1, 0];
        for (int i = 1; i < quizDate.GetLength(1); i++)
        {
            buttonText = GameObject.Find("Button" + i).GetComponentInChildren<Text>();

            buttonText.text = quizDate[1, i];
        }

    

    }
    public void Quetion2()
    {
        quizDate = csvManager.ReadCsvFile("CSV/quiz");
        text.text = quizDate[2, 0];
        for (int i = 1; i < quizDate.GetLength(1); i++)
        {
            buttonText = GameObject.Find("Button" + i).GetComponentInChildren<Text>();

            buttonText.text = quizDate[2, i];

        }
    }
    public void Quetion3()
    {
        quizDate = csvManager.ReadCsvFile("CSV/quiz");
        text.text = quizDate[3, 0];
        for (int i = 1; i < quizDate.GetLength(1); i++)
        {
            buttonText = GameObject.Find("Button" + i).GetComponentInChildren<Text>();

            buttonText.text = quizDate[3, i];

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
        Text selectedBtn = GameObject.Find("Button2").GetComponentInChildren<Text>();


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
    public void QuetionAnswer3()
    {
        Text selectedBtn = GameObject.Find("Button3").GetComponentInChildren<Text>();


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
        Text selectedBtn = GameObject.Find("Button4").GetComponentInChildren<Text>();


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
