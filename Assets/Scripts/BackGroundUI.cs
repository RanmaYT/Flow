using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class BackGroundUI : MonoBehaviour
{
    [SerializeField] TMP_Text pointsText;
    [SerializeField] GameManager gameManager;

    private void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        pointsText.SetText("POINTS: " + gameManager.pointsCount);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
