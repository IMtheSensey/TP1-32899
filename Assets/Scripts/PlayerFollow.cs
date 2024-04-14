using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; 
    public Vector3 offset; 

 
    void Update()
    {
        if (target != null)
        {
           
            Vector3 desiredPosition = target.position + offset; //camera follow
           
            transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * 5f);
        }
    }
}
