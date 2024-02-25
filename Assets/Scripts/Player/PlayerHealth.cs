using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamageable
{

    [Header ("Config")]
    [SerializeField] private PlayerStats stats;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(1f); 
        }
    }

    public void TakeDamage(float amount)
    {
        if (stats.health > 0)
        {
            stats.health -= amount;
        }

        if (stats.health <= 0)
        {
            PlayerDead();
        }
    }

    private void PlayerDead() 
    {
        Debug.Log("Player Dead");
    }
}
