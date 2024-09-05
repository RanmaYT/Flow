using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuUI : MonoBehaviour
{
    [SerializeField] private AudioSource clickSound;

    public void StartGame()
    {
        clickSound.Play();
        SceneManager.LoadScene(1);
    }

    public void Guide()
    {
        clickSound.Play();
        SceneManager.LoadScene(2);
    }

    public void Exit()
    {
        clickSound.Play();
        Application.Quit();
    }
}
