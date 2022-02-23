using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PongManager : MonoBehaviour
{
    [SerializeField] private PongGoal rightGoal;
    [SerializeField] private PongGoal leftGoal;
    [SerializeField] private PongBall ball;
    [SerializeField] private TMP_Text rightScoreText;
    [SerializeField] private TMP_Text leftScoreText;
    [SerializeField] private int scoreToWin;
    [SerializeField] private TMP_Text winnerText;

    private int rightScore =0;
    private int leftScore =0;

    private void Awake()
    {
        rightGoal.onScore += HandleRightScore;
        leftGoal.onScore += HandleLeftScore;
        ball.Restart();
    }
    private void HandleRightScore()
    {
        leftScore++;
        HandleScore();
    }
    private void HandleLeftScore()
    {
        rightScore++;
        HandleScore();
    }
    private void HandleScore()
    {
        ball.Restart();
        rightScoreText.text = rightScore.ToString();
        leftScoreText.text = leftScore.ToString();
        if (rightScore == scoreToWin){
            winnerText.text = "Right Player Wins!";
            RestartGame();
        }
        else if (leftScore == scoreToWin)
        {
            winnerText.text = "Left Player Wins!";
            RestartGame();
        }
    }
    private static readonly WaitForSeconds restartWait = new WaitForSeconds(5);
    private void RestartGame()
    {
        Destroy(ball);
        StartCoroutine(WaitForReload());

        IEnumerator WaitForReload()
        {
            yield return restartWait;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }


}
