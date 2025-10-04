using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required for scene management

public class GameController : MonoBehaviour
{
    // Load a scene by its name
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    // Quit the game (only works in a built game, not in the editor)
    public void QuitGame()
    {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
