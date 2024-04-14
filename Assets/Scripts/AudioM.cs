using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
   [SerializeField] AudioSource musicSource;
   [SerializeField] AudioSource SFXSource;

   public AudioClip background;
   public AudioClip click;


   private void Start(){
   musicSource.clip = background;   //Menu music
   musicSource.Play();
   }  

   public void PlaySFX(AudioClip clip) //Click for buttons
   {

      SFXSource.PlayOneShot(clip);
   }
}