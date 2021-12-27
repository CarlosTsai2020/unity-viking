using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    bool alive = true;

    public float speed = 15f;
    public float horizontalMultiplier = 2f;
    public Rigidbody rb;

    public int turnOp = 3;

    float horizontalInput;

    [SerializeField] float jumpForce = 800f;

    private void FixedUpdate()
    {
        if (!alive) return;
        Vector3 forwaedMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwaedMove + horizontalMove);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            Die();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        if (this.turnOp >= 1)
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.Rotate(0, -90f, 0);
                this.turnOp = 0;
            }

            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.Rotate(0, 90f, 0);
                this.turnOp = 0;
            }
        }
    }

    public void Die()
    {
        alive = false;
        SceneManager.LoadScene("GameOver");
    }


    void Jump()
    {
        float height = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f);
        if(isGrounded)
        rb.AddForce(Vector3.up * jumpForce);
    }

}
