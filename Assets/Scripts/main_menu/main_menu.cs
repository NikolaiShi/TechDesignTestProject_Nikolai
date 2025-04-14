using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    private void Start()
    {
        music_manager.Instance.PlayMusic("menu_music");
    }

    public void HiddenObjectSceneStart()
    {
        music_manager.Instance.PlayMusic("hidden_object_music");
        SceneManager.LoadScene("hidden_object");
    }

    public void KnightInTheForestSceneStart()
    {
        music_manager.Instance.PlayMusic("knight_music");
        SceneManager.LoadScene("knight_in_the_forest");
    }

    public void Quit()
    {
        Application.Quit();
    }

}