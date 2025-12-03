using JetBrains.Annotations;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static Player Instance;

    [SerializeField] private int maxHealth = 50;
    [SerializeField] private int health;
    [SerializeField] private int block = 0;

    public int Health => health;
    public int Block => block;

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
        int damageLeft = amount;
        if (block > 0)
        {
            int blockUsed = Mathf.Min(block, damageLeft);
            block -= blockUsed;
            damageLeft -= blockUsed;
        }

        health -= damageLeft;

        if (health <= 0)
        {
            health = 0;
            OnPlayerDeath();
        }
    }

    public void AddBlock(int amount)
    {
        block += amount;
    }

    public void ResetBlock()
    {
        block = 0;
    }

    public void Heal(int amount)
    {
        health = Mathf.Min(health + amount, maxHealth);
    }

    private void OnPlayerDeath()
    {
        Debug.Log("DEAD");
    }
}


