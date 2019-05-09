using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool startPlaying;

    public string levelName;


    bool gameHasEnded = false;

    void Start()
    {

    }


  /*  void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;

            }
        }

    }
*/

    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            SceneManager.LoadScene(levelName);
        }
          
    }

}
