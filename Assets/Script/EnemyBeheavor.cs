using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBeheavor : MonoBehaviour
{
    [SerializeField] private bool DeathMark;
    public int health; 


    // Start is called before the first frame update
    void Start()
    {
        DeathMark = false; 
        health = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gettingDeathMark() 
    {
        DeathMark = true;
    }
}
