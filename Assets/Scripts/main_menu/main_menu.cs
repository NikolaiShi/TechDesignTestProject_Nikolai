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

    public void Quit()
    {
        Application.Quit();
    }
}