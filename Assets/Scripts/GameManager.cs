using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class GameManager : MonoBehaviour
{
    // 싱글턴 패턴으로 구현(Singletone)
    public static GameManager gm;
    // public GameObject scoreObject;
    public Text scoreText; // Legacy 방식의 Text Component
    public TMP_Text scoreTextTMP; // Text Mesh Pro 방식의 Text Component
    public Text bestScoreText;
    public GameObject gameOverUI;

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

        // CurrentScoreText의 값을 "0"으로 초기화 한다.
        // scoreText.text = "0";
        scoreTextTMP.text = "0";

        // "BestScore"라는 Key로 저장된 Data가 있다면...
        if (PlayerPrefs.HasKey("BestScore"))
        {
            // BestScoreText에 저장된 Best Score를 읽어와서 표시한다.
            bestScore = PlayerPrefs.GetInt("BestScore");
            bestScoreText.text = bestScore.ToString();
        }
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
        // scoreText.text = currentScore.ToString();
        scoreTextTMP.text = currentScore.ToString();

        // If, 추가된 현재 점수가 기록중인 최고 점수보다 더 높다면
        if (currentScore > bestScore)
        {
            // 최고 점수를 현재 점수로 갱신한다.
            bestScore = currentScore;

            bestScoreText.text = bestScore.ToString();
        }
    }

    public int GetBestScore()
    {
        return bestScore;
    }

    // GameOver UI를 활성화 or 비활성화 해주는 Function
    public void ShowGameOverUI(bool activation)
    {
        // Panel Object를 활성화 한다.
        gameOverUI.SetActive(activation);

        // App의 시간흐름을 0배율로 변경한다.
        Time.timeScale = 0;
    }

    // Game Restart Function
    public void Restart()
    {
        // print("재시작 버튼이 클릭되었습니다!!");

        // 현재 Scene을 다시 시작(Load)한다.
        SceneManager.LoadScene(0);

        // App의 시간흐름을 1배율로 변경한다.
        Time.timeScale = 1;
    }

    // App 종료함수를 만들어 준다.
    public void AppQuit()
    {
#if UNITY_EDITOR
        // Unity Editor의 PlayMode를 종료한다.
        EditorApplication.ExitPlaymode();

#elif UNITY_STANDALONE
        // Application을 종료한다.(Unity에서 Play중 일 때는 사용 불가능하다.)
        Application.Quit();
#endif
    }
}
