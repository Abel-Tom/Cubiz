using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamedOver : MonoBehaviour
{
    public GameObject YouWinPanel;
    public GameObject Panel;

    JoyStickMovement movement;

    void Start()
    {
        
    }

    void Update()
    {
        fell();
    }

    void  fell()
    {
        if(gameObject.transform.position.y < -2)
        {
            Panel.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (YouWinPanel.activeSelf != true)
        {
            if (collision.collider.tag == "Maze" || collision.collider.tag == "Enemy")
            {
                Panel.SetActive(true);
                movement = GetComponent<JoyStickMovement>();
                movement.enabled = !movement.enabled;
            }
        }
    }
}
