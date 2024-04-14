using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healthAmount = 100; 
    public float rotationSpeed = 50f; 
    public AudioClip pickupSound; 

    void Update()
    {
        
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime); //pickup rotation
        transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Pickup just for Player
        {
            
            CharacterHealth playerHealth = other.GetComponent<CharacterHealth>();

            if (playerHealth != null)
            {
                
                playerHealth.RestoreHealth(healthAmount);

           
                if (pickupSound != null)
                {
                    AudioSource.PlayClipAtPoint(pickupSound, transform.position); //audion sound
                }

                
                Destroy(gameObject);
            }
        }
    }
}
