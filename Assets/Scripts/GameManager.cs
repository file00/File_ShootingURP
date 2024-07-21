using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // 싱글턴 패턴으로 구현(Singletone)
    public static GameManager gm;
    // public GameObject scoreObject;
    public Text scoreText;
    public Text bestScoreText;

    int currentScore = 0;
    int bestScore = 0;

    void Awake()
    {
        if (gm == null)
        {
            gm = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        // ScoreText Component를 Caching 하기
        // scoreText = scoreObject.GetComponent<Text>();

        // ScoreText의 값을 "0"으로 초기화 한다.
        scoreText.text = "0";
    }

    void Update()
    {
        
    }

    // Point를 받아서 현재 Score 변수의 값을 증감하는 Function
    public void AddScore(int point)
    {
        currentScore += point;
        // print(currentScore);
        // 현재 Score(숫자)를 문자열로 변경해서 UI의 ScoreText에다가 값으로 전달한다. 
        scoreText.text = currentScore.ToString();

        // If, 추가된 현재 점수가 기록중인 최고 점수보다 더 높다면
        if (currentScore > bestScore)
        {
            // 최고 점수를 현재 점수로 갱신한다.
            bestScore = currentScore;

            bestScoreText.text = bestScore.ToString();
        }
    }
}
