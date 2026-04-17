using UnityEngine;

public class door : MonoBehaviour
{
    [Header("Settings")]
    public float openAngle = 90f;
    public float speed = 3f;
    public float openDistance = 3f;

    [Header("References")]
    public Transform player;

    private bool isOpen = false;
    private Quaternion closedRotation;
    private Quaternion openRotation;

    void Start()
    {
        closedRotation = transform.rotation;
        openRotation = Quaternion.Euler(0, openAngle, 0) * closedRotation;
    }

    void Update()
    {
        // Vérifie la distance joueur → porte
        float distance = Vector3.Distance(player.position, transform.position);

        if (distance <= openDistance)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                isOpen = !isOpen;
            }
        }

        // Animation ouverture / fermeture
        if (isOpen)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, openRotation, Time.deltaTime * speed);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, closedRotation, Time.deltaTime * speed);
        }
    }
}