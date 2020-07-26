using UnityEngine;

public class LevelEnabler : MonoBehaviour {
    public bool Button2;
    public bool Button3;
    public bool Button4;
    public bool Button5;
    public bool Button6;
    public bool Button7;
    public bool Button8;
    public GameObject button2;
    public GameObject button3;
    public GameObject button4;
    public GameObject button5;
    public GameObject button6;
    public GameObject button7;
    public GameObject button8;

   public void Start () {
       
    }
	
	
	public void Update () {

        Button2 = FindObjectOfType<LevelComplete>().Button2;
        Button3 = FindObjectOfType<LevelComplete>().Button3;
        Button4 = FindObjectOfType<LevelComplete>().Button4;
        Button5 = FindObjectOfType<LevelComplete>().Button5;
        Button6 = FindObjectOfType<LevelComplete>().Button6;
        Button7 = FindObjectOfType<LevelComplete>().Button7;
        Button8 = FindObjectOfType<LevelComplete>().Button8;

        if (Button2)
        {
            button2.SetActive(false);
        }
        if (Button3)
        {
            button3.SetActive(false);
        }
        if (Button4)
        {
            button4.SetActive(false);
        }
        if (Button5)
        {
            button5.SetActive(false);
        }
        if (Button6)
        {
            button6.SetActive(false);
        }
        if (Button7)
        {
            button7.SetActive(false);
        }
        if (Button8)
        {
            button8.SetActive(false);
        }


    }
}
