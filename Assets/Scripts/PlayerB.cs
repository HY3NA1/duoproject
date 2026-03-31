using UnityEngine;

public class PlayerB : MonoBehaviour
{
    private Rigidbody2D RB;
    public float jforce = 10;
    public float jforceair = 25;
    public float gforce = 1;
    public float speed = 10;
    private bool grounded;
    private Animator aninr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Physics2D.gravity *= gforce;

        aninr = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha4) && grounded)
        {
            RB.AddForce(Vector2.up * jforce, ForceMode2D.Impulse);
            grounded = false;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            aninr.SetFloat("Speed", -1);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            aninr.SetFloat("Speed", 1);
        }
        else
        {
            aninr.SetFloat("Speed", 0);
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
        if (other.gameObject.CompareTag("cloud"))
        {
            RB.AddForce(Vector2.up * jforce, ForceMode2D.Impulse);
        }
    }
}
