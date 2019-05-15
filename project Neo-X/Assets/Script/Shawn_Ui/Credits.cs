using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("quit"); 
        Application.Quit();
    }
    public void ReturnToMenu(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

}
