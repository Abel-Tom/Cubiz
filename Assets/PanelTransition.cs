using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelTransition : MonoBehaviour
{
    public GameObject PanelContainer;

   public  void PanelOne()
    {
        PanelContainer.transform.position = (new Vector3(-1000, 0, 0));
    }
    public void PanelTwo()
    {
        PanelContainer.transform.position = (new Vector3(-3000, 0, 0));
    }
    public void PanelThree()
    {
        PanelContainer.transform.position = (new Vector3(-5000, 0, 0));
    }
}
