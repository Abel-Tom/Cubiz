using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public bool Button2 = false;
    public bool Button3 = false;
    public bool Button4 = false;
    public bool Button5 = false;
    public bool Button6 = false;
    public bool Button7 = false;
    public bool Button8 = false;
   
    public static LevelComplete instance;

    private void Start()
    {
        LoadPlayer();
    }

   /* void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        

    }*/
   
   
    

    public void EndGame()
    { 
        int Level = SceneManager.GetActiveScene().buildIndex;

        if (Level == 1)
        {
            Button2 = true;
        }
        if (Level == 2)
        {
            Button3 = true;
        }
        if (Level == 3)
        {
            Button4 = true;
        }
        if (Level == 4)
        {
            Button5 = true;
        }
        if (Level == 5)
        {
            Button6 = true;
        }
        if (Level == 6)
        {
            Button7 = true;
        }
        if (Level == 7)
        {
            Button8 = true;
        }
    }


    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }



    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();

        Button2 = data.Button2;
        Button3 = data.Button3;
        Button4 = data.Button4;
        Button5 = data.Button5;
        Button6 = data.Button6;
        Button7 = data.Button7;
        Button8 = data.Button8;

    }

  

}