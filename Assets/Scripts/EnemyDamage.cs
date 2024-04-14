using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;
    public AudioSource audioSource; 
    public AudioClip hurtSound; 
    public AudioClip deathSound; 


    void Start()
    {
        currentHealth = maxHealth;
        audioSource = GetComponent<AudioSource>();
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt"); //skeleton hurt animation

        
        if (audioSource != null && hurtSound != null)
        {
            audioSource.PlayOneShot(hurtSound); //skeleton hurt animation
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        
        animator.SetBool("IsDead", true);

        if (audioSource != null && deathSound != null)
        {
            audioSource.PlayOneShot(deathSound); //death sound
        }

     
        GameObject colliderObject = GameObject.FindGameObjectWithTag("Collider");
        if (colliderObject != null && gameObject.CompareTag("Boss"))
        {
            
            Collider collider = colliderObject.GetComponent<Collider>(); //activation of win collider for last enemy
            if (collider != null)
            {
                 collider.isTrigger = true;
            }
        }

        Destroy(gameObject, 2.5f);
    }
}
