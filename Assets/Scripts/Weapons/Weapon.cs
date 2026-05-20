using UnityEngine;

[CreateAssetMenu(fileName = "Weapon", menuName = "Weapons/New Weapon")]
public class Weapon : ScriptableObject
{
    public GameObject attackPrefab;
    public float cooldown;
    
}
