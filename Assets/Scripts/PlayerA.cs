using System.Runtime.CompilerServices;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerA : MonoBehaviour
{
    private Rigidbody2D RB;
    public float jforce = 10;
    public float gforce = 1;
    public float speed = 10;
    private bool grounded;
    private Animator anin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        Physics2D.gravity *= gforce;

        anin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            RB.AddForce(Vector2.up * jforce, ForceMode2D.Impulse);
            grounded = false;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
            anin.SetFloat("Speed", -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
            anin.SetFloat("Speed", 1);
        }
        else
        {
            anin.SetFloat("Speed", 0);
        }
    }


    private void OnTriggerEnter2D (Collider2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            grounded = true;
        }
    }
}
