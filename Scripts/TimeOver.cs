using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimeOver : MonoBehaviour
{
    public static int currentLevel;

    int countDownStartValue = 10;
    public Text timerUI;
    // Start is called before the first frame update
    void Start()
    {
        countDownTimer();
    }

    void countDownTimer()
    {
        if (countDownStartValue > 0)
        {
            timerUI.text = "Timer:" + countDownStartValue;
            countDownStartValue--;
            Invoke("countDownTimer", 1.0f);
        }

        else
        {
            timerUI.text = "GameOver!";
            SceneManager.LoadScene(currentLevel);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
