using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public AudioSource walkSound; 

    void Start()
    {
        walkSound = GetComponent<AudioSource>();
    }

    void Update()
    {   
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput).normalized; //player movement
        bool isMoving = movement.magnitude > 0f;

        if (isMoving)
        {       
            Quaternion targetRotation = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime); //player rotation
            
            if (!walkSound.isPlaying) 
            {
                walkSound.Play(); 
            }
        }
        else
        {
            walkSound.Stop(); 
        }

        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}
