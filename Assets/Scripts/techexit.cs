using UnityEngine;

public class techexit : MonoBehaviour
{
    private bool techinrange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (techinrange)
        {
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                Debug.Log("Tech has Exited");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TECHGUY"))
        {
            techinrange = true;
        }
    }
}
