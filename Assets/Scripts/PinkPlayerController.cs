using UnityEngine;
using UnityEngine.InputSystem;
public class PinkPlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Rigidbody rb;
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal_PinkPlayer");
        rb.linearVelocity = (new Vector3(0, 0, 1) * Time.deltaTime * speed * h);
    }
}
