using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   
    public void EasyButton()
    {
        StartCoroutine(EasyScene());
    }

    public void NormalButton()
    {
        StartCoroutine(NormalScene());

    }

    public void HardButton()
    {
        StartCoroutine(HardScene());

    }

    public void InsaneButton()
    {
        StartCoroutine(InsaneScene());

    }

    public void FastButton()
    {
        StartCoroutine(FastScene());

    }

    public void MainMenuButton()
    {
        StartCoroutine(MenuScene());

    }

    public void RestartButton()
    {
        StartCoroutine(RestartScene());

    }

    public void InstructionsButton()
    {
        StartCoroutine(InstructionsScene());

    }

    public void QuitButton()
    {
        StartCoroutine(QuitScene());

    }

    IEnumerator EasyScene()
    {
        yield return new WaitForSeconds(0.45f);
        SceneManager.LoadScene("EasyScene");
    }

    IEnumerator NormalScene()
    {
        yield return new WaitForSeconds(0.45f);
        SceneManager.LoadScene("NormalScene");
    }

    IEnumerator HardScene()
    {
        yield return new WaitForSeconds(0.45f);
        SceneManager.LoadScene("HardScene");
    }

    IEnumerator InsaneScene()
    {
        yield return new WaitForSeconds(0.45f);
        SceneManager.LoadScene("InsaneScene");
    }

    IEnumerator FastScene()
    {
        yield return new WaitForSeconds(0.45f);
        SceneManager.LoadScene("FastScene");
    }

    IEnumerator MenuScene()
    {
        yield return new WaitForSeconds(0.45f);
        SceneManager.LoadScene("Menu");
    }

    IEnumerator RestartScene()
    {
        yield return new WaitForSeconds(0.45f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator InstructionsScene()
    {
        yield return new WaitForSeconds(0.45f);
        SceneManager.LoadScene("Instructions");
    }

    IEnumerator QuitScene()
    {
        yield return new WaitForSeconds(0.45f);
        Application.Quit();
    }
}
