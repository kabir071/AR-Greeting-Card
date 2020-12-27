using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
   public void greetingcard()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void snowman()
    {
        SceneManager.LoadScene("Rotate");
    }

    public void exitgame()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
