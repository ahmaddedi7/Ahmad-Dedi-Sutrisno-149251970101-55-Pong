using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Game");
        Debug.Log("Created By Ahmad Dedi S - 149251970101-55");
    }

    public void OpenAuthor()
    {
        Debug.Log("Created By Gue");
    }
}
