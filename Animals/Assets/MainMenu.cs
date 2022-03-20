using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//Go to the next scene level as in build settings
    }
    public void QuitGame(){
        Debug.Log("Quitted the game!");
        Application.Quit();
    }
}