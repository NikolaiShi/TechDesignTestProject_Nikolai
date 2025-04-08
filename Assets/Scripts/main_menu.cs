using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu : MonoBehaviour
{
    private void Start()
    {
        music_manager.Instance.PlayMusic("menu_music");
    }
    public void FirstSceneButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void Quit()
    {
        Application.Quit();
    }
}