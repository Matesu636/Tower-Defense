using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{

    public float health;
    KillCounter killCouterScript;

    // Start is called before the first frame update
    void Start()
    {
        killCouterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
    }

    // Update is called once per frame
    void Update()
    {


        

    }


    public void TakeDamage()
    {


        if (health <= 0)
        {
            
            
            Destroy(transform.gameObject);
            killCouterScript.AddScore();
            

        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        TakeDamage();
        if (other.gameObject.CompareTag("Finish"))
        {
            Destroy(transform.gameObject);
        }
    }
   
}