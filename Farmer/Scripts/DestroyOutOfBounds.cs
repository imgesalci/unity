using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DestroyOutOfBounds : MonoBehaviour
{
    private readonly float topBound = 30;
    private readonly float lowerBound = -5;
    static int lives = 0;
    public bool isDead;

    void Start()
    {
        isDead = false;
    }
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Destroy(gameObject);
            lives = lives + 1;
            if(lives % 3 == 0 && !isDead)
            {
                isDead = true;
                Time.timeScale = 0;
            }
        }
    }
        
}
