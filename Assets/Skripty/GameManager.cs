using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    


    // Start is called before the first frame update
    private void Start()
    {
        
    }
     

    // Update is called once per frame
    void Update()
    {
        if(KillCounter.lives<=0)
        {
            EndGame();
        }
    }
    void EndGame()
    {
        Debug.Log("Game Over");
        
        
        
    }
}
