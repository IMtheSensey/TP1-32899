using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    AudioManager audioManager;
    private void Awake(){
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();



    }

    public void PlayGame()
    {
        audioManager.PlaySFX(audioManager.click);
        SceneManager.LoadScene("Story");  //story loader
    }

        public void Sound()
    {
        audioManager.PlaySFX(audioManager.click); //button click
      
    }


    public void FirstScene()
    {
        SceneManager.LoadScene("Outside");  //outside scene loader
    }


    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}