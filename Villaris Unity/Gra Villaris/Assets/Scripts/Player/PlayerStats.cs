using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField]
    private float maxHealth;

    [SerializeField]
    private GameObject
        deathChunkParticle,
        deathBloodParticle;

    private float currentHealth;

    private GameManager GM;
    public PasekZycia pasekZycia;

    public GameObject ekran;

    private void Start()
    {
        currentHealth = maxHealth;
       // GM = GameObject.Find("GameManager").GetComponent<GameManager>();
        pasekZycia = GameObject.FindObjectOfType<PasekZycia>();
        pasekZycia.UstawMaxHP(maxHealth);
        pasekZycia.UstawHP(currentHealth);
    }

    public void DecreaseHealth(float amount)
    {
        currentHealth -= amount;
        pasekZycia.UstawHP(currentHealth);
        if (currentHealth <= 0.1f)
        {
            Die();
        }
    }

    private void Die()
    {
        Instantiate(deathChunkParticle, transform.position, deathChunkParticle.transform.rotation);
        Instantiate(deathBloodParticle, transform.position, deathBloodParticle.transform.rotation);
        //GM.Respawn();
        Destroy(gameObject);
        ekran.SetActive(true);
    }


}
