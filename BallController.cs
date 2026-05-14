using UnityEngine;

public class BallController : MonoBehaviour
{
    public Rigidbody rb;

    [Header("Movement")]
    public float jumpForce = 6f;
    public float superSpeedForce = 20f;

    [Header("Super Speed")]
    public bool superSpeed;
    public float superSpeedTime = 5f;

    private float timer;

    private void Start()
    {
        timer = superSpeedTime;
    }

    private void Update()
    {
        if (superSpeed)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                superSpeed = false;
                timer = superSpeedTime;
            }
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        }

        if (collision.gameObject.CompareTag("Danger"))
        {
            GameManager.instance.gameOver = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Speed"))
        {
            superSpeed = true;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (superSpeed)
        {
            rb.velocity = new Vector3(
                rb.velocity.x,
                -superSpeedForce,
                rb.velocity.z
            );
        }
    }
}
