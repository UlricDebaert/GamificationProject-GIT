using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GB_MainMenu : MonoBehaviour
{
    [Tooltip("Start Game Scene name.")]
    public string playGame;

    public GameObject mainMenu;

    [Tooltip("Options Scene name.")]
    public GameObject optionsMenu;

    [Tooltip("Credits Scene name.")]
    public GameObject creditsMenu;


    private void Start()
    {
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }


    public void PlayGame()
    {
        SceneManager.LoadScene(playGame);
    }

    public void OptionsMenu()
    {
        optionsMenu.SetActive(true);
        creditsMenu.SetActive(false);
        mainMenu.SetActive(false);
    }

    public void CreditsMenu()
    {
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void _MainMenu()
    {
        optionsMenu.SetActive(false);
        creditsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}