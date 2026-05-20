using System;
using UnityEngine;

/// <summary>
/// Responsável por tirar vida e destruir um inimigo
/// </summary>
public class EnemyHealth : MonoBehaviour
{
        public int maxLife;

        int currentLife;

        private void Awake()
        {
            currentLife = maxLife;

        }
    

  public void TakeDamage(int damage)
{
    currentLife -= damage;
    
    if (currentLife <= 0)
    {
        Die();
        Destroy(gameObject);
    }
}

void Die()
    {
        Debug.Log("Enemy died!");

    }

}
