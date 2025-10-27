using UnityEngine;
using TMPro;

public class MiniHeart : MonoBehaviour  // Changed from MiniHeart for "stars"
{
    public static int score = 0;           // Shared score for all stars
    public int goal = 5;                   // Number of stars needed to win
    public TextMeshProUGUI scoreText;      // Text to show score
    public TextMeshProUGUI winText;        // Text to show win message

    void Start()
    {
        UpdateScoreText();
        if (winText != null)
            winText.text = ""; // Clear win message at start
    }

    // Detect collision with player (3D physics)
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            score++;
            UpdateScoreText();
            Debug.Log("Star collected! Score: " + score);  // Updated log
            
            // Destroy this star immediately
            Destroy(gameObject);

            // Check if player won
            if (score >= goal && winText != null)
            {
                winText.text = "❤️ Love Full! You Win! ❤️";  // Your exact text
                // Optional: Simple fade-out win text after 3s (add Coroutine for bonus)
                // StartCoroutine(FadeWinText());
            }
        }
    }

    void UpdateScoreText()
    {
        if (scoreText != null)  // Extra null check
            scoreText.text = "Score: " + score.ToString();
    }

    public static void ResetScore()
    {
        score = 0;
    }

    // Optional bonus: Fade win text (requires using System.Collections;)
    // private System.Collections.IEnumerator FadeWinText()
    // {
    //     yield return new WaitForSeconds(3f);
    //     winText.text = "";
    // }
}