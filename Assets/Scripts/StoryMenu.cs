using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathMenu : MonoBehaviour
{
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

   public AudioClip backgroundS;
   public AudioClip clickS;
   AudioManager audioManager;

   private void Awake(){
  
   audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();


   musicSource.clip = backgroundS;
   musicSource.Play();

   SFXSource.PlayOneShot(clickS);
   }  

    public void FirstScene()
    {
        SceneManager.LoadScene("Outside");
    }

   public void PlaySFX()
   {

      SFXSource.PlayOneShot(clickS);
   }
  
}