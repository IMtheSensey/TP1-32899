using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggeredMessage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        
        if (GetComponent<Collider>().isTrigger)
        {
             SceneManager.LoadScene("Win"); //win scene load
        }
    }
}
