using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager {
    //UI System
    public bool startPlaying;

    public string levelName;


    bool gameHasEnded = false;
    //UI System
    public event System.Action<Player> OnLocalPlayerJoined;
    private GameObject gameObject;
    private static GameManager m_instance;

    //Can only create one instance of a GameManager object
    public static GameManager Instance {

        get {
            if(m_instance == null) {
                m_instance = new GameManager();
                m_instance.gameObject = new GameObject("_gameManager");
                m_instance.gameObject.AddComponent<InputController>();
            }
            return m_instance;
        }

    }

    private InputController m_InputController;
    public InputController inputController {
        get {
            if (m_InputController == null) {
                m_InputController = gameObject.GetComponent<InputController>();
            }
            return m_InputController;
        }
    }

    private Player m_localPlayer;
    public Player LocalPlayer {
        get {
            return m_localPlayer;
        }
        set {
            m_localPlayer = value;
            if(OnLocalPlayerJoined != null) {
                OnLocalPlayerJoined(m_localPlayer);
            }
        }

    }

    public void EndGame()//UI System By Lu
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("game over");
            SceneManager.LoadScene(levelName);
        }

    }

}


