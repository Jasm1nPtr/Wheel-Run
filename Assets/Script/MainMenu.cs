using System.Collections;
using System.Collections.Generic;
using UnityEngine;
﻿using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGameBlue()
    {
        SceneManager.LoadScene("Blue");
    }

    public void PlayGameBlack()
    {
        SceneManager.LoadScene("Black");
    }

    public void PlayGameYellow()
    {
        SceneManager.LoadScene("Yellow");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
