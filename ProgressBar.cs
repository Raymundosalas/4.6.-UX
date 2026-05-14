using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Slider slider;

    public Transform player;
    public Transform startPoint;
    public Transform endPoint;

    private float totalDistance;

    private void Start()
    {
        totalDistance = startPoint.position.y - endPoint.position.y;
    }

    private void Update()
    {
        float currentDistance = startPoint.position.y - player.position.y;

        float progress = currentDistance / totalDistance;

        slider.value = progress;
    }
}
