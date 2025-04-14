using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class collectibles_manager : MonoBehaviour
{
    public TextMeshProUGUI gemUI;
    int numGemsCollected = 0;

    private void OnEnable()
    {
        gem.OnGemCollected += GemCollected;
    }

    private void OnDisable()
    {
        gem.OnGemCollected -= GemCollected;
    }

    private void GemCollected(gem clickedGem)
    {
        numGemsCollected++;
        gemUI.text = numGemsCollected.ToString() + "/3";
        sound_manager.Instance.PlaySound2D("click_gem");
        if(numGemsCollected>=3)
        {
            sound_manager.Instance.PlaySound2D("victory");
        }
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("main_menu");
    }
}