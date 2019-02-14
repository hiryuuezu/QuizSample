using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    string[,] quizDate;
    public Text buttonText;
    public Text quizText;
    int quizCount;
    int quizNumber;
    string collectAnswer;
    string[] selectedAnswer;
    GameObject quizM;
    //基本理念：くりかえしはさける
    //=>もしなんどもこぴぺしているなとかんじたら、まとめられないか考える。
    //つねにインデントは揃える => {}の位置がわからなくなる。
    //空白行も無駄に増やさない。
    //拡張するときはできるだけ少ない変更で済むように(たとえばくいずを増やす場合CSVの更新だけで済むように)
    //違う場所だけ変数にする
    //条件が満たされれば呼び出す函数を場合、void updateに書くのは無駄が多い。



    // Use this for initialization
    void Start()
    {
        quizCount = 1;
        quizM = GameObject.Find("QuizM");
        quizDate = csvManager.ReadCsvFile("CSV/quiz");//重い処理なので頻繁に呼び出していたら疑う。
        quizNumber = quizDate.GetLength(0);
        selectedAnswer = new string[quizNumber-1];
        Debug.Log(quizNumber);
        DisplayQuestion(quizCount);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DisplayQuestion(int dataRow)
    {

        quizText.text = quizDate[dataRow, 0];
        for (int i = 1; i < quizDate.GetLength(1) -1; i++)
        {
            buttonText = GameObject.Find("Button" + i).GetComponentInChildren<Text>();
            buttonText.text = quizDate[dataRow, i];

        }
        collectAnswer = quizDate[dataRow, 5];

    }

    public void SelectAnswer(int buttonNumber) 
    {
        Text selectedBtn = GameObject.Find("Button" + buttonNumber.ToString()).GetComponentInChildren<Text>();
        selectedAnswer[quizCount] = selectedBtn.text;
        if (selectedBtn.text == collectAnswer)
        {
            Debug.Log("正解");
        }
        else
        {
            Debug.Log("不正解");
        }

        quizCount++;
        if (quizCount == quizNumber)
        {
            //PlayerPrefs.
            SceneManager.LoadScene("EndScene");
            return;
        }
        Debug.Log(quizCount);
        DisplayQuestion(quizCount);
    }

}
