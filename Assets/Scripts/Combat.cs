using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;

    public int attackDamage = 20;
    public float attackRate = 2f;
    float nextAttackTime = 0f;


    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown("l"))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;   //atack rate controller
               
                          
               
               
            }
        }
    }

    void Attack()
    {
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);  //Collider overlap detection

        foreach (Collider enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage); //damage
        }
    }

    void OnDraw()
    {
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
