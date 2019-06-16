using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public GameObject InventoryUI;
    public GameObject pause;
    public bool pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (GameIsPaused)
            {
                Inventory();
            }
            else
            {
                InventoryOpen();
            }
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu = !pauseMenu;

        }

        if (pauseMenu)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            Resume();
        }
        else
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Pause();
        }

    }

    void Resume()
    {
        pause.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    void Pause()
    {
        pause.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    void Inventory()
    {
        InventoryUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void InventoryOpen()
    {
        InventoryUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

}
