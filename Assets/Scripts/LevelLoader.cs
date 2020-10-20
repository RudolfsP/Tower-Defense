﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour {

    [SerializeField] float loadTime = 2.5f;
    int currentSceneIndex;


    // Start is called before the first frame update
    void Start() {
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if(currentSceneIndex == 0) {
            StartCoroutine(WaitForTime());
        }
        
    }

    IEnumerator WaitForTime() {
        yield return new WaitForSeconds(loadTime);
        LoadNextScene();

    }

    public void LoadMainMenu() {
        Time.timeScale = 1;
        SceneManager.LoadScene("Start Screen");
    }

    public void RestartScene() {
        Time.timeScale = 1;
        SceneManager.LoadScene(currentSceneIndex);
    }

    public void LoadNextScene() {
        SceneManager.LoadScene(currentSceneIndex + 1);
    }

    public void LoadYouLose() {
        SceneManager.LoadScene("Lose Screen");
    }

    public void QuitGame() {
        Application.Quit();
    }


}
