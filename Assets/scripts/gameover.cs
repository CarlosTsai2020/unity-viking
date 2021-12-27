using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class gameover : MonoBehaviour
{
    public Text tt;
    public Text ss;

    public void menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void Update()
    {
        tt.text = GameUI.time;
        ss.text = GameUI.score;
    }
}
