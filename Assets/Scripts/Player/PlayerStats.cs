using UnityEngine;


[CreateAssetMenu(fileName = "PlayerStats", menuName = "2D RPG/Scriptable Objects/Player Stats", order = 0)]

public class PlayerStats : ScriptableObject


{
    [Header ("Config")]
    public int level;

    [Header("Health")]
    public float health;
    public float maxHealth;
}
