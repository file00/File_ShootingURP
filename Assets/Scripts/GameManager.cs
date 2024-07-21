using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // �̱��� �������� ����(Singletone)
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
        // ScoreText Component�� Caching �ϱ�
        // scoreText = scoreObject.GetComponent<Text>();

        // ScoreText�� ���� "0"���� �ʱ�ȭ �Ѵ�.
        scoreText.text = "0";
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
        scoreText.text = currentScore.ToString();

        // If, �߰��� ���� ������ ������� �ְ� �������� �� ���ٸ�
        if (currentScore > bestScore)
        {
            // �ְ� ������ ���� ������ �����Ѵ�.
            bestScore = currentScore;

            bestScoreText.text = bestScore.ToString();
        }
    }
}
