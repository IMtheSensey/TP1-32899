using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StoryMenu : MonoBehaviour
{
   [SerializeField] AudioSource SFXSource;

   public AudioClip death;
  
   private void Awake(){
   SFXSource.PlayOneShot(death); //death scream
}
  
  
}