using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class PlayerMovement : MonoBehaviour
{
    public float Movement;
    public Rigidbody2D rb;
    public float speed;
    bool grounded;

  

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        speed = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Movement * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            float jumpvelocity = 70f;
            rb.velocity = Vector2.up * jumpvelocity;
        }
    }



    private void OnCollisionEnter2D(UnityEngine.Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            grounded = true;
        }

    }

    private void OnCollisionExit2D(UnityEngine.Collision2D other)
    {
        if (other.gameObject.CompareTag("Platform"))
        {
            grounded = false;
        }
    }

    }




