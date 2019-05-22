using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
///ЫЫЫ сразу видно скомунизженый код)0
/// </summary>
public class Menu : MonoBehaviour {
    public void OnClickStart() //PLay
    {
        SceneManager.LoadScene("main");
    }
    public void OnClickQuit() //Quit
    {
        Application.Quit();
    }
    public void Options()
    {
        SceneManager.LoadScene("Options"); //Options
    }
    public void Back()
    {
        SceneManager.LoadScene("menu"); //Back
    }
    public void Author()
    {
        SceneManager.LoadScene("Author"); //Автор
    }
    public void Shop()
    {
        SceneManager.LoadScene("Shop");
    }


}
