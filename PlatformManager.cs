using UnityEngine;

public class PlatformManager : MonoBehaviour
{
    public Transform player;

    private void Update()
    {
        if (transform.position.y > player.position.y + 20f)
        {
            Destroy(gameObject);
        }
    }
}
