using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    private const int damageAmount = 20;

    private void OnTriggerEnter(Collider other)
    {
        CharacterHealth characterHealth = other.gameObject.GetComponent<CharacterHealth>(); //collison damage handler
        if (characterHealth != null)
        {
            characterHealth.TakeDamage(damageAmount);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        CharacterHealth characterHealth = collision.gameObject.GetComponent<CharacterHealth>();
        if (characterHealth != null)
        {
            characterHealth.TakeDamage(damageAmount);
        }
    }
}
