using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class UiManager : MonoBehaviour
{
    [SerializeField] private TMP_Text pointsText;
    [SerializeField] private PlayerPointsCounter playerPoints;

    [SerializeField] private TMP_Text boosterText;
    [SerializeField] private PlayerMovement playerBooster;

    [SerializeField] private GameManager gameManager;
    [SerializeField] private TMP_Text risingText;

    private float showingTime = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Points();

        Booster();

        Rising();
    }

    private void Points()
    {
        pointsText.SetText("POINTS: " + playerPoints.points);
    }

    private void Booster()
    {
        if (playerBooster.usedBooster)
        {
            boosterText.SetText("BOOSTER CD: " + Mathf.Round(playerBooster.cooldown));
        }
        else
        {
            boosterText.SetText("BOOSTER: V");
        }
    }

    private void Rising()
    {
        if(gameManager.isRising)
        {
            showingTime -= Time.deltaTime;
            risingText.SetText("THE FLOW IS RISING, OBSTACLES WILL APPEAR FASTER");
        }

        if(showingTime <= 0)
        {
            risingText.SetText("STABLE");
            gameManager.isRising = false;
            showingTime = 5;
        }
    }
}
