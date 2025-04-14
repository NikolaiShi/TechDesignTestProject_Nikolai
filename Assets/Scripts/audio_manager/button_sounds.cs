using UnityEngine;

public class button_sounds : MonoBehaviour
{
    public void Hover()
    {
        sound_manager.Instance.PlaySound2D("hover");
    }

    public void ClickButton()
    {
        sound_manager.Instance.PlaySound2D("click_button");
    }
}

