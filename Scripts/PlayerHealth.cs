using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] float health = 100f;



    public void TakeDamage(float damageReceived)
    {
        health -= damageReceived;
        if (health <= 0)
        {
            GetComponent<DeathHandler>().HandleDeath();

        }

    }

}
