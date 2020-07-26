using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerStayAwake : MonoBehaviour
{
    public static AudioManagerStayAwake instance;
    void Awake()
    {

        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

    }
}
