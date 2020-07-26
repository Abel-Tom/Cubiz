using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[System.Serializable]
public class PlayerData {

    public bool Button2;
    public bool Button3;
    public bool Button4;
    public bool Button5;
    public bool Button6;
    public bool Button7;
    public bool Button8;
   

   

    public PlayerData(LevelComplete player)
    {
        Button2 = player.Button2;
        Button3 = player.Button3;
        Button4 = player.Button4;
        Button5 = player.Button5;
        Button6 = player.Button6;
        Button7 = player.Button7;
        Button8 = player.Button8;
    }

}
