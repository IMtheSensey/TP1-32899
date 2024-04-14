 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 5f;
    public float stoppingDistance = 2f; 
    Transform target;
    NavMeshAgent agent;
    public Animator animator;
    public static bool myGlobalBool;

    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public int attackDamage = 20;

    public AudioSource attackAudio; 
    public AudioClip attackSound; 
    public float attackCooldown = 1f; 
    private float lastAttackTime = -Mathf.Infinity; 

    void Start()
    {
        target = PlayerTracker.instance.player.transform;
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = stoppingDistance;

        attackAudio = GetComponent<AudioSource>(); 
    }


    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position); //Activate when in seeing distance
        if (distance <= lookRadius)
        {
            animator.SetBool("SeeYou", true);
            agent.SetDestination(target.position); 
            if (distance <= agent.stoppingDistance) //if in stop distance - attack
            {
                animator.SetBool("Attack", true);
                FaceTraget();
                myGlobalBool = true;
                if (Time.time >= lastAttackTime + attackCooldown)
                {
                    Attack(); 
                    lastAttackTime = Time.time; // Update the last attack time
                }
            }
            if (distance >= agent.stoppingDistance)
            {
                animator.SetBool("Attack", false);
                animator.SetTrigger("Escape");
                myGlobalBool = false;
            }
        }
    }

    void FaceTraget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z)); 
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f); //smooth
    }

    void Attack()
    {
        
        if (attackAudio != null && attackSound != null)
        {
            attackAudio.PlayOneShot(attackSound); //attack sound
        }

   
        Collider[] hitEnemies = Physics.OverlapSphere(attackPoint.position, attackRange, enemyLayers);
        foreach (Collider enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage); //colider overlap - attack
            
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lookRadius);
    }
}