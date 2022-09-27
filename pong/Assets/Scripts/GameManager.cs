using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Ball ball;
    public Paddle playerPaddle;
    public Paddle computerPaddle;
    public Text PlayerScoreText;
    public Text coputerScoreText;
    private int _playerScore;
    private int _computerScore;

    public void PlayerScores()
    {
        _playerScore++;
        this.PlayerScoreText.text = _playerScore.ToString();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
    }

    public void computerScores()
    {
        _computerScore++;
        this.coputerScoreText.text = _computerScore.ToString();
        this.playerPaddle.ResetPosition();
        this.computerPaddle.ResetPosition();
        this.ball.ResetPosition();
    }
}
