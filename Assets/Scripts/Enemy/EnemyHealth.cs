using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    /// <summary>
    /// Responsável por tirar vida e destruir um inimigo
    /// </summary>
    /// 
    public class EnemyHealth : MonoBehaviour
    {
        public int maxLife;

        int currentLife;

        private void Awake()
        {
            currentLife = maxLife;

        }
    }
}
