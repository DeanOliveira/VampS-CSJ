using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public float duration;

    private void Start()
    {
        Destroy(gameObject, duration);
    }
}
