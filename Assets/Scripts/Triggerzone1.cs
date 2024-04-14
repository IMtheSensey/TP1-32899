using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
             SceneManager.LoadScene("Level1"); //trigerzone for gate
        }
    }
}
