using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject settingsPanel;
    public void da()
    {
            Application.LoadLevel("Exit");

    }
    public void net()
    {
          Application.LoadLevel("Menu");
    }
}
