using UnityEngine;

public class SuperSpeedEffect : MonoBehaviour
{
    public ParticleSystem speedParticles;

    private BallController player;

    private void Start()
    {
        player = FindObjectOfType<BallController>();
    }

    private void Update()
    {
        if (player.superSpeed)
        {
            if (!speedParticles.isPlaying)
            {
                speedParticles.Play();
            }
        }
        else
        {
            if (speedParticles.isPlaying)
            {
                speedParticles.Stop();
            }
        }
    }
}
