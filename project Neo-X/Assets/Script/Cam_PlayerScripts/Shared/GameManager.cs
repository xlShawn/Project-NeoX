using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager {

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
}


