using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameInput : MonoBehaviour
{
    //ba�lang��taki girdinin onclick'inde playerName atanacak.
    public void SetPlayerName(string nick)
    {
        PlayerPrefs.SetString("CurrentName", nick);
    }
}
