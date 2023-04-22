using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
{
    public TMP_InputField playerName;
    public TextMeshProUGUI bestScore;

    private void Start() {
        bestScore.text = "BEST SCORE\n" + PlayerPrefs.GetString("Name", "") + " : " + PlayerPrefs.GetInt("Highscore", 0);
    }

    public void StartNew() {
        if (!string.IsNullOrEmpty(playerName.text)){
            PlayerStats.Instance.PlayerName = playerName.text;
            SceneManager.LoadScene(1);
        }
    }


    public void ExitApp() {
        PlayerPrefs.SetInt("Highscore", PlayerStats.Instance.maxScore);
        PlayerPrefs.SetString("Name", PlayerStats.Instance.PlayerName);

        #if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
        #else
            Application.Quit();
        #endif
    }
}
