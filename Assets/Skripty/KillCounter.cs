using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KillCounter : MonoBehaviour
{

    public Text counterText;
    public static int Money;
    public int startMoney = 400;

    public Text livesText;
    public static int lives;
    public int startLives = 3;

    // Start is called before the first frame update
    void Start()
    {
        Money = startMoney;
        lives = startLives;
    }

    // Update is called once per frame
    void Update()
    {
        ShowScore();
        ShowLives();
        
    }

    private void ShowScore()
    {
        counterText.text = Money.ToString();
    }

    private void ShowLives()
    {
        livesText.text = lives.ToString();
    }

    public void AddScore()
    {
        Money += 5;
    }
    public void RemoveScore()
    {

        Money -= 20;

        
    }
    
     
}   
