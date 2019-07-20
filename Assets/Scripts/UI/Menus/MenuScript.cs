using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    void Start()
    {
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
        LevelingScript.newGame();
    }
    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
