using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform BulletPos;
    private float timer;
    private GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");

        float distance = Vector2.Distance(transform.position, player.transform.position);
        Debug.Log(distance);

        if (distance < 5)
        {
            timer += Time.deltaTime;

            if (timer > 1)
            {
                timer = 0;
                shoot();
            }
        }
    }
        void shoot()
        {
            Instantiate(bullet, BulletPos.position, Quaternion.identity);
        }
}
