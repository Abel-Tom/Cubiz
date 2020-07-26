using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    public float CoinsToCollect;
    public Text CoinsLeft;
    public GameObject YouWinPanel;
    AudioSource AudioData;
    private void Start()
    {
        AudioData = GetComponent<AudioSource>();
        CoinsLeft.text = "Coins Left: " + CoinsToCollect.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Coin")
        {
            CoinsToCollect -= 1;
            CoinsLeft.text = "Coins Left: " + CoinsToCollect.ToString();
            AudioData.Play();
        }

        if(CoinsToCollect == 0)
        {
            YouWinPanel.SetActive(true);
        }

    }

   

   
   
    }




   

