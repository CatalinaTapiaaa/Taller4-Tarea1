using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayUI : MonoBehaviour
{
    public GameObject panelPausa;

    public void Pausar()
    {
        Time.timeScale = 0;
        panelPausa.SetActive(true);
    }
    public void Reanudar()
    {
        Time.timeScale = 1;
        panelPausa.SetActive(false);
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
