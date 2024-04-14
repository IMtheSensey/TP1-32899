using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class CharacterHealth : MonoBehaviour
{
   public int maxHealth = 500;
    int currentHealth;
    public Healthbar healthbar;
    
    
    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth); //health set
  
    }

    public void TakeDamage(int damageAmount)
    {
        if (EnemyController.myGlobalBool == true){
        currentHealth = currentHealth -= damageAmount; //damage add

        healthbar.SetHealth(currentHealth);
    

         }
        if (currentHealth <= 0) {
              SceneManager.LoadScene("Death");
        }
        
    }

    public void RestoreHealth(int healthAmount) {
        
        currentHealth = currentHealth + healthAmount;
        
        if (currentHealth > 500) {

            currentHealth = 500;    //limit max health when adding health

        }
         healthbar.SetHealth(currentHealth);

    }


  
}
