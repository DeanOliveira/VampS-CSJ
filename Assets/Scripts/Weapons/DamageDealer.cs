using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damage;

    private void OnTriggerEnter2D(Collider2D other)
    {
        EnemyHealth health = other.GetComponent<EnemyHealth>();

        if (health != null)
        {
            health.TakeDamage(damage);
        }

    }
}
