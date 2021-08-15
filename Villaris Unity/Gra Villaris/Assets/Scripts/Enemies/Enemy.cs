using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float m_speed = 1.0f;
    [SerializeField] float m_jumpForce = 2.0f;

    private Rigidbody2D m_body2d;
    private Sensor_Bandit m_groundSensor;
    private bool m_grounded = false;
    private bool m_combatIdle = false;
    private bool m_isDead = false;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public float attackRate = 2f;
    public float nextAttackTime = 0;
    public LayerMask enemyLayers;

    public int attackDamage = 40;
    public int maxHealth = 100;
    public int currentHealth;

    public PasekZycia pasekZycia;
    public Animator animator;

    void Start(){
        
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage){
        
        currentHealth -= damage;

        animator.SetTrigger("Hurt");

        if(currentHealth <= 0){

            Die();

        }
    }

    void Die() 
    {
        animator.SetBool("isDead", true);

        GetComponent<Rigidbody2D>().simulated = false;
        this.enabled = false;

    }
}
