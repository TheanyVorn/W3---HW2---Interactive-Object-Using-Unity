using UnityEngine;
using TMPro;

public class MiniHeart : MonoBehaviour
{
    public static int score = 0;
    public int goal = 5;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;
    void Start()
    {
        UpdateScoreText();
        if (winText != null)
            winText.text = "";
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score++;
            UpdateScoreText();

            Destroy(gameObject);

            if (score >= goal && winText != null)
            {
                winText.text = "You Win!";
            }
        }
    }
    void UpdateScoreText()
    {
        if (scoreText != null)
            scoreText.text = "Score: " + score.ToString();
    }
    public static void ResetScore()
    {
        score = 0;
    }
}