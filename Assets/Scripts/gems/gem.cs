using System;
using UnityEngine;

public class gem : MonoBehaviour, i_collectible
{
    public static event Action<gem> OnGemCollected;

    [SerializeField]
    private ParticleSystem collectParticle;
    void OnMouseDown()
    {
        Collect();
    }
    public void Collect()
    {
        OnGemCollected?.Invoke(this);

        Instantiate(collectParticle, transform.position, Quaternion.identity);

        Debug.Log("Gem collected!");
        Destroy(gameObject, 1f);
    }
}