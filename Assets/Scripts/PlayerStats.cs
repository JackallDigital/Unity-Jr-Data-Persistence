using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {
    public static PlayerStats Instance;

    public string PlayerName;
    public int maxScore;

    private void Awake() {
        if (Instance != null) {
            Destroy(gameObject);
            return;
        }
        Instance = this;

        DontDestroyOnLoad(gameObject);
    }

    private void Start() {
        PlayerName = "";
        maxScore= 0;
    }
}
