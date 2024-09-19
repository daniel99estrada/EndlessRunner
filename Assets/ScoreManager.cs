using UnityEngine;
using TMPro; // Use this if you're using TextMeshPro
// using UnityEngine.UI; // Uncomment this line if you're using the default UI Text

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // For TextMeshPro
    // public Text scoreText; // Uncomment this line if you're using the default UI Text

    public int score;
    public float scoreIncreaseRate = 500f; // Points per second

    void Start()
    {
        score = 0;
        UpdateScoreText();
    }

    void Update()
    {
        // Increment score based on time
        score += Mathf.FloorToInt(scoreIncreaseRate * Time.deltaTime);
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "" + score; // Update the displayed score
    }
}
