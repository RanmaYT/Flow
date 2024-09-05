using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuideUI : MonoBehaviour
{
    [SerializeField] AudioSource clickSound;

    public void MainMenu()
    {
        clickSound.Play();
        SceneManager.LoadScene(0);
    }
}
