using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackExit : MonoBehaviour
{
    public void back()
    {
        SceneManager.LoadScene("MenuImage");
    }

   

    public void exitgame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
