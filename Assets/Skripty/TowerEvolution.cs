using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerEvolution : MonoBehaviour
{

    public GameObject Tower;
    public Transform TowerPos;
    public GameObject Budova;
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

    
    public void OnMouseDown()
    {
        if (KillCounter.Money < 20)
        {
            Debug.Log("No peníze");
            return;
        }
        Instantiate(Tower, TowerPos.position, Quaternion.identity);
        Destroy(Budova);
        if(gameObject.CompareTag("Destroyer"))
        {
            Destroy(gameObject);

            killCouterScript.RemoveScore();
            
        }
    }
}
