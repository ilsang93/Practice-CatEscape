using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Button leftButton, rightButton;
    [SerializeField] private Image hpGauge;
    [SerializeField] private GameObject gameOverText;
    [SerializeField] private Button retryButton;
    [SerializeField] private Text timeScoreText;

    [HideInInspector] public bool isGameOver = false;


    private float score;
    public float Score { get => score; set {
            if (isGameOver) return;
            score = value;
            scoreText.text = "Score : " + score;
        }
    }
    private float timeScore = 0f;
    public float TimeScore { get => timeScore; set {
            if (isGameOver) return;
            timeScore = value;
            timeScoreText.text = "Time : " + (int)timeScore;
        } }

    private int hp = 10;
    public int Hp { get => hp; set {
            if (isGameOver) return;

            hp = value;
            hpGauge.fillAmount = hp * 0.1f;

            if (hp <= 0) {
                GameOver();
            }
        } }

    private void Start()
    {
        retryButton.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        });
        Application.targetFrameRate = 60;
    }

    private void Update()
    {
        TimeScore += Time.deltaTime;
    }

    private void GameOver() {
        isGameOver = true;
        InputManager.instance.GameOver();
        gameOverText.SetActive(true);
        print("GameOver");
    }
}
