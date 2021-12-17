﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    [SerializeField] GameObject gameOver, restartBtn;
    [SerializeField] float playTime = 30f;

    void Start()
    {
        EndTime();
    }

    void EndTime()
    {
        if(RemainTime.rTime <= 0)
        {
            Time.timeScale = 0;
            gameOver.gameObject.SetActive(true);
            restartBtn.gameObject.SetActive(true);
        }
    }

    public void restartGame()
    {
        gameOver.gameObject.SetActive(false);
        restartBtn.gameObject.SetActive(false);
        Time.timeScale = 1;
        RemainTime.rTime = playTime;
        SceneManager.LoadScene("GetTime");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
