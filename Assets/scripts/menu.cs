using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("Game");
    }
    public void instruction()
    {
        SceneManager.LoadScene("instruction");
    }
    public void quit()
    {
        Application.Quit();
    }
}
