using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Path : MonoBehaviour
{

    [SerializeField] private Transform[] waypoints;
    [SerializeField] private float Speed = 2f;
    private int waypointsIndex = 0;
    KillCounter killCounterScript;

    // Start is called before the first frame update
    void Start()
    {
        killCounterScript = GameObject.Find("KCO").GetComponent<KillCounter>();
        transform.position = waypoints[waypointsIndex].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        if (waypointsIndex < waypoints.Length - 1)
        {
            transform.position = Vector2.MoveTowards(transform.position, waypoints[waypointsIndex].transform.position, Speed * Time.deltaTime);

            if(transform.position==waypoints[waypointsIndex].transform.position)
            {
                waypointsIndex += 1;
            }
        }

        if (waypointsIndex> waypoints.Length -2)
        {
            EndPath();
        }
    }
    void EndPath()
    {
        KillCounter.lives--;
        Destroy(gameObject);
    }

    
}
