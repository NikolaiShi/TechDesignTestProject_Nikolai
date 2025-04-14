using UnityEngine;
using UnityEngine.SceneManagement;

public class KnightUI : MonoBehaviour
{
    public void BakcToMenu()
    {
        SceneManager.LoadScene("main_menu");
    }
}
