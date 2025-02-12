using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public TextMeshProUGUI timeCount;
    public float currentTimer = 0;
    public int timerDisplay = 0; 

    // Start is called before the first frame update
    void Start()
    {
        timeCount.text = "Time: " + timerDisplay; 
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTimer += Time.deltaTime; 
        timeCount.text = "Time: " + timerDisplay;
        timerDisplay = (int)currentTimer; 

        if(currentTimer >= 10f) 
        {
            Debug.Log("10 seconds passed");
            currentTimer = 0; 
            
        }

    }
}
