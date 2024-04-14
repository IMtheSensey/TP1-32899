using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class InsideAudio : MonoBehaviour
{
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

   public AudioClip backgroundS;
   public AudioClip skeletonhit;
   public AudioClip health;
   public AudioClip swing;
   public AudioClip skeletonDeath;
   public AudioClip OpenGate;

   
    private float attackRate = 2f;
    float nextAttackTime = 0f;

    void Update()
    {
        if (Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown("l"))
            {
              
                nextAttackTime = Time.time + 1f / attackRate; //attack sound
               
               SFXSource.PlayOneShot(swing);
                
               
               
            }
        }
    }


   private void Awake(){
  



   musicSource.clip = backgroundS;
   musicSource.Play();

   SFXSource.PlayOneShot(OpenGate); //gate open sound
   }  




   public void PlayHealth()
   {

      SFXSource.PlayOneShot(health);   //health sound
   }

    public void PlaySkeletonHit()
   {

      SFXSource.PlayOneShot(skeletonhit);    //sound when skeleton hits
   }

       public void PlaySkeletonDeath()
   {

      SFXSource.PlayOneShot(skeletonDeath); //death of skeleton
   }
   
   
  
  
}