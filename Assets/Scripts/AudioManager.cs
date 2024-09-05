using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] GameManager gameManager;
    [SerializeField] AudioSource gameSound;
    [SerializeField] AudioSource gameOverSound;
    [SerializeField] AudioSource riverSound;

    bool isPlayingSomething;
    bool gameOverPlaying;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameManager.isGameOver)
        {
            if(!isPlayingSomething)
            {
                gameSound.Play();
                riverSound.Play();
            }
            isPlayingSomething = true;
        }
        else
        {
            if(isPlayingSomething && !gameOverPlaying)
            {
                gameSound.Stop();
                riverSound.Stop();

                gameOverPlaying = true;

                gameOverSound.Play();
            }
        }
    }
}
