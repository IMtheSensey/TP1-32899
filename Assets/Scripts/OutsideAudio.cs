using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class OutsideAudio : MonoBehaviour
{
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

   public AudioClip backgroundS;
   public AudioClip clickS;
   public AudioClip walk;
   public AudioClip swing;
   OutsideAudio audioManager;

   void Update()
    {

       
        
        if (Input.GetKeyDown("l")){
         SFXSource.PlayOneShot(swing); //slash sound
          
          }

   }
    
   private void Awake(){
  



   musicSource.clip = backgroundS;
   musicSource.Play();

   SFXSource.PlayOneShot(clickS);
   }  

   


   public void PlaySFX()
   {

      SFXSource.PlayOneShot(clickS);
   }
   
   public void WalkSound()
   {
    
    SFXSource.volume = 0.5f;
    SFXSource.PlayOneShot(walk);
    
    
    SFXSource.volume = 1f;
   }
  
}