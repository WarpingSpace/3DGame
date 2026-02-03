using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [Header("Movement Settings")]
    [SerializeField] private Vector3 moveDirection = Vector3.up; // Set to Up
    [SerializeField] private float distance = 5f;
    [SerializeField] private float speed = 2f;

    [Header("Rotation Settings")]
    [SerializeField] private Vector3 rotationAxis = Vector3.up;
    [SerializeField] private float rotationSpeed = 50f;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void FixedUpdate()
    {
        // Calculate movement
        // Using Mathf.PingPong or modifying Sin to stay in positive range (0 to 1)
        float movement = Mathf.PingPong(Time.time * speed, distance);

        // Apply movement and rotation
        transform.position = startPosition + (moveDirection.normalized * movement);
        transform.Rotate(rotationAxis, rotationSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}