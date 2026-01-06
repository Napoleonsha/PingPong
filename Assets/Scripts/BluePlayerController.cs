using UnityEngine;
using UnityEngine.InputSystem;
public class BluePlayerController : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] Rigidbody rb;
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal_BluePlayer");
        rb.linearVelocity = (new Vector3(0, 0, 1) * Time.deltaTime * speed * h);
    }
}
