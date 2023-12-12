using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int level = 1;
    public int score = 0;
    public int lives = 3;
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
    private void Start()
    {
        // Load the first scene
        NewGame();
    }
    private void NewGame()
    {
        // Load the first scene
        this.score = 0;
        this.lives = 3;

        LoadLevel(1);
    }
    private void LoadLevel(int level)
    {
        // Load the specified scene
        this.level= level;
        SceneManager.LoadScene("Level" + level);
    }
}