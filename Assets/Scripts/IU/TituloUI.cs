using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TituloUI : MonoBehaviour
{
    public Animator ani;

    public void Gameplay()
    {
        Time.timeScale = 1;
        AnimacionAbrirGameplay();
    }
    public void Tutorial()
    {
        Time.timeScale = 1;
        AnimacionAbrirTutorial();
    }
    public void Creditos()
    {
        Time.timeScale = 1;
        AnimacionAbrirCreditos();
    }

    private IEnumerator AnimacionAbrirGameplay()
    {
        ani.SetBool("Abrir", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
    private IEnumerator AnimacionAbrirTutorial()
    {
        ani.SetBool("Abrir", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(1);
    }
    private IEnumerator AnimacionAbrirCreditos()
    {
        ani.SetBool("Abrir", true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(3);
    }
}
