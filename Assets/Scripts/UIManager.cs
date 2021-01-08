#pragma warning disable 0649
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Text scoreText, healthText, winLoseText;
    [SerializeField] private Image winLoseBG;

    private void OnEnable()
    {
        Player.OnDamage += UpdateHealt;
        Player.OnCollect += UpdateScore;
        Player.OnDead += Dead;
        Player.OnGoal += Goal;
    }

    private void OnDisable()
    {
        Player.OnDamage -= UpdateHealt;
        Player.OnCollect -= UpdateScore;
        Player.OnDead -= Dead;
        Player.OnGoal -= Goal;
    }

    private void UpdateHealt(int health) => healthText.text = $"Health : {health}";

    private void UpdateScore(int score) => scoreText.text = $"Score: {score}";

    private void Dead()
    {
        winLoseBG.gameObject.SetActive(true);
        winLoseText.text = "Game Over!";
        winLoseText.color = Color.white;
        winLoseBG.color = Color.red;
    }

    private void Goal()
    {
        winLoseBG.gameObject.SetActive(true);
        winLoseText.text = "You Win!";
        winLoseText.color = Color.black;
        winLoseBG.color = Color.green;
    }
}
