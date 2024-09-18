using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highscoreText;
    public TextMeshProUGUI pointsText;

    public static int score = 0;
    int highscore = 0;
    int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString(); 
        pointsText.text = "Points: " + points.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        highscoreText.text = "Highscore: " + highscore.ToString();
        pointsText.text = "Points: " + points.ToString();
    }

    


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "shot")
        {
            score++;
            highscore++;
            points++;
        }
    }
}
