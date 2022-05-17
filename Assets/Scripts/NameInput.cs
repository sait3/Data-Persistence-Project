using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameInput : MonoBehaviour
{
    public Text EntranceText;
    public Text ScoreText;
    public string input;

    public void SetPlayerName(string nick)
    {
        input = nick;
        PlayerPrefs.SetString("CurrentName", input);
        PlayerPrefs.Save();
    }

    private void LateUpdate()
    {
        EntranceText.text = PlayerPrefs.GetString("HighName"); 
        ScoreText.text = $"{(PlayerPrefs.GetInt("HighScore"))}"; 
    }

}
