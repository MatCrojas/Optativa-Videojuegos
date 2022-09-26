using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string GameName;

    // Start is called before the first frame update
    public void StartGame()
    {
        SceneManager.LoadScene(GameName);
    }

    // Update is called once per frame
    public void ExitGame()
    {
        Application.Quit();
    }
}
