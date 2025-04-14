using UnityEngine;

public class animation_controller : MonoBehaviour
{
    [SerializeField]
    private Animator animator;
   
    [SerializeField]
    private float interval_for_glow = 5f;

    private float timer = 0f;

    private void OnEnable()
    {
        gem.OnGemCollected += GemCollected;
    }

    private void OnDisable()
    {
        gem.OnGemCollected -= GemCollected;
    }
    void Update()
    {
        timer += Time.deltaTime; 

        if (timer >= interval_for_glow) 
        {
            animator.SetTrigger("start_glow");
            timer = 0f; 
        }
    }

    void GemCollected(gem clickedGem) 
    {
        if (clickedGem.gameObject == gameObject)
        {
            animator.SetTrigger("on_click");
        }
    }
}
