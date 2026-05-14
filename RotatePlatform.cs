using UnityEngine;

public class RotatePlatform : MonoBehaviour
{
    public float rotationSpeed = 100f;

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float direction = Input.GetAxis("Mouse X");

            transform.Rotate(0f, -direction * rotationSpeed * Time.deltaTime, 0f);
        }
    }
}
