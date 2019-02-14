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
    //拡張するときはできるだけ少ない変更で済むように(たとえばくいずを増やす場合CSVの更新だけで済むように)
    //違う場所だけ変数にする



    // Use this for initialization
    void Start()
    {
        quizCount = 0;
        quizM = GameObject.Find("QuizM");
        DisplayQuestion(1);

    }

    // Update is called once per frame
    void Update()
    {
        switch (quizCount)
        {
            case 1:
                DisplayQuestion(2);
                break;
            case 2:
                DisplayQuestion(3);
                break;
            case 3:
                PlayerPrefs.SetInt("count", trueCount);
                SceneManager.LoadScene("EndScene");
                break;
        }
    }

    public void DisplayQuestion(int dataRow)
    {
        quizDate = csvManager.ReadCsvFile("CSV/quiz");
        text.text = quizDate[dataRow, 0];
        for (int i = 1; i < quizDate.GetLength(1) -1; i++)
        {
            buttonText = GameObject.Find("Button" + i).GetComponentInChildren<Text>();
            buttonText.text = quizDate[dataRow, i];
        }
    }
    public void SelectAnswer(int buttonNumber) 
    {
        Text selectedBtn = GameObject.Find("Button" + buttonNumber.ToString()).GetComponentInChildren<Text>();


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
