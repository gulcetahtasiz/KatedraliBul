using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class AdvancedPlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 120f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Devrilmeyi engellemek için:
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;
    }

    void Update()
    {
        Rotate();
    }

    void FixedUpdate() // Rigidbody ile çalışırken hareket FixedUpdate'te olmalı
    {
        Move();
    }

    void Move()
    {
        float inputZ = Input.GetAxis("Vertical"); 
        Vector3 move = transform.forward * inputZ * moveSpeed;
        Vector3 newVelocity = new Vector3(move.x, rb.velocity.y, move.z);
        rb.velocity = newVelocity;
    }

    void Rotate()
    {
        float inputX = Input.GetAxis("Horizontal");

        // Küçük değerleri sıfırla (örneğin gamepad titremesi gibi)
        if (Mathf.Abs(inputX) < 0.05f)
            inputX = 0f;

        float rotationAmount = inputX * rotationSpeed * Time.deltaTime;
        transform.Rotate(0f, rotationAmount, 0f);
    }
}
