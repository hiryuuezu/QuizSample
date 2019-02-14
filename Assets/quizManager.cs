using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    string[,] quizDate;
    public Text buttonText;
    public Text text;



    // Use this for initialization
    void Start()
    {


        Quetion1();

    }

    // Update is called once per frame
    void Update()
    {



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
}
