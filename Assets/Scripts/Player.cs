using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 5;
    private int score = 0;

    public static Action<int> OnDamage;
    public static Action<int> OnCollect;
    public static Action OnDead;
    public static Action OnGoal;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health == 0)
            OnDead();

        OnDamage?.Invoke(health);
    }

    public void SetScore(int score)
    {
        this.score += score;
        OnCollect?.Invoke(this.score);
    }
}
