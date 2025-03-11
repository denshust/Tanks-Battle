using ArionDigital;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public float health;
    public float maxHealth;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0) 
        {
            Die();
        }
    }

    private void Die()
    {
        if (TryGetComponent<CrashCrate>(out CrashCrate component))
        {
            component.OnDeath();
            Destroy(gameObject,5);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Heal(float healAmount)
    {
        health += healAmount;
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }
}
