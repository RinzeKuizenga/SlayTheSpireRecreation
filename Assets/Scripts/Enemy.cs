using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static Enemy Instance;

    [SerializeField] private int maxHealth = 30;
    [SerializeField] private int health;
    [SerializeField] private int attackDamage = 6;

    public int Health => health;
    public int AttackDamage => attackDamage;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }

    public void PerformAttack()
    {
        Player.Instance.TakeDamage(attackDamage);
    }

    private void Die()
    {

    }
}
