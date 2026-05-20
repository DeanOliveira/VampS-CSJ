using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Weapon weapon;

    float timer;

    private void Update()
    {
        timer += Time.deltaTime; // soma segundos em tempo real
        if (timer >= weapon.cooldown)
        {
            Attack();
            timer = 0;
        }
    }

    void Attack()
    {
        Instantiate(weapon.attackPrefab, transform.position, Quaternion.identity); // Cria o prefab do ataque na posição do jogador
    }
}
