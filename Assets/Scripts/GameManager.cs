using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;
using TMPro;

public class GameManager : MonoBehaviour
{
    // �̱��� �������� ����(Singletone)
    public static GameManager gm;
    // public GameObject scoreObject;
    public Text scoreText; // Legacy ����� Text Component
    public TMP_Text scoreTextTMP; // Text Mesh Pro ����� Text Component
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
        // ScoreText Component�� Caching �ϱ�
        // scoreText = scoreObject.GetComponent<Text>();

        // CurrentScoreText�� ���� "0"���� �ʱ�ȭ �Ѵ�.
        // scoreText.text = "0";
        scoreTextTMP.text = "0";

        // "BestScore"��� Key�� ����� Data�� �ִٸ�...
        if (PlayerPrefs.HasKey("BestScore"))
        {
            // BestScoreText�� ����� Best Score�� �о�ͼ� ǥ���Ѵ�.
            bestScore = PlayerPrefs.GetInt("BestScore");
            bestScoreText.text = bestScore.ToString();
        }
    }

    void Update()
    {
        
    }

    // Point�� �޾Ƽ� ���� Score ������ ���� �����ϴ� Function
    public void AddScore(int point)
    {
        currentScore += point;
        // print(currentScore);
        // ���� Score(����)�� ���ڿ��� �����ؼ� UI�� ScoreText���ٰ� ������ �����Ѵ�. 
        // scoreText.text = currentScore.ToString();
        scoreTextTMP.text = currentScore.ToString();

        // If, �߰��� ���� ������ ������� �ְ� �������� �� ���ٸ�
        if (currentScore > bestScore)
        {
            // �ְ� ������ ���� ������ �����Ѵ�.
            bestScore = currentScore;

            bestScoreText.text = bestScore.ToString();
        }
    }

    public int GetBestScore()
    {
        return bestScore;
    }

    // GameOver UI�� Ȱ��ȭ or ��Ȱ��ȭ ���ִ� Function
    public void ShowGameOverUI(bool activation)
    {
        // Panel Object�� Ȱ��ȭ �Ѵ�.
        gameOverUI.SetActive(activation);

        // App�� �ð��帧�� 0������ �����Ѵ�.
        Time.timeScale = 0;
    }

    // Game Restart Function
    public void Restart()
    {
        // print("����� ��ư�� Ŭ���Ǿ����ϴ�!!");

        // ���� Scene�� �ٽ� ����(Load)�Ѵ�.
        SceneManager.LoadScene(0);

        // App�� �ð��帧�� 1������ �����Ѵ�.
        Time.timeScale = 1;
    }

    // App �����Լ��� ����� �ش�.
    public void AppQuit()
    {
#if UNITY_EDITOR
        // Unity Editor�� PlayMode�� �����Ѵ�.
        EditorApplication.ExitPlaymode();

#elif UNITY_STANDALONE
        // Application�� �����Ѵ�.(Unity���� Play�� �� ���� ��� �Ұ����ϴ�.)
        Application.Quit();
#endif
    }
}
