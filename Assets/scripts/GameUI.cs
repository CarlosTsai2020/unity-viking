using System.Timers;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameUI : MonoBehaviour
{
    public Text timeAmount;
    public Text collectAmount;
    public static string time = "存活時間 00:00";
    public static string score= "水晶數量 : 0";
    int coinAmount = 0;
    int count = 0;
    int seconds = 0;

    private void Start()
    {
        collectAmount.text = "水晶數量 : 0";
        timeAmount.text = "存活時間 00:00";
    }

    public void AddCollectAmount()
    {
        coinAmount++;
        collectAmount.text = "水晶數量 : " +  coinAmount.ToString();
        score = collectAmount.text;
    }

    private void FixedUpdate()
    {
        count++;
        if (count == (int)(1.0f / Time.fixedDeltaTime))
        {
            seconds++;
            timeAmount.text = "存活時間 " + (seconds / 60).ToString("00") + ":" + (seconds % 60).ToString("00");
            time = timeAmount.text;
            count = 0;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

}

