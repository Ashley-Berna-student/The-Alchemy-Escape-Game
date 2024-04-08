using UnityEngine;

public class Jump : MonoBehaviour
{
    public float jumpForce = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void PerformAction()
    {
        JumpAction();
    }

    void JumpAction()
    {
        rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
    }
}

