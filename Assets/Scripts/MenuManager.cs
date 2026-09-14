using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject howToPlayPanel;
    public GameObject creditsPanel;

    public GameObject exitButton;
    public GameObject decreaseFontButton;
    public GameObject increaseFontButton;
    public GameObject instructionText;

    public void PlayGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void ShowHowToPlay()
    {
        howToPlayPanel.SetActive(true);
        SetMainControls(false);
    }

    public void HideHowToPlay()
    {
        howToPlayPanel.SetActive(false);
        SetMainControls(true);
    }

    public void ShowCredits()
    {
        creditsPanel.SetActive(true);
        SetMainControls(false);
    }

    public void HideCredits()
    {
        creditsPanel.SetActive(false);
        SetMainControls(true);
    }

    public void ExitGame()
    {
        Debug.Log("Saliendo de Guardianes del Bosque...");
        Application.Quit();
    }

    private void SetMainControls(bool state)
    {
        exitButton.SetActive(state);
        decreaseFontButton.SetActive(state);
        increaseFontButton.SetActive(state);
        instructionText.SetActive(state);
    }
}