using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject door;
    private bool techinrange;
    private bool magicinrange;
    private bool open;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (techinrange)
        {
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                if (!open)
                {
                    door.SetActive(false);
                    open = true;
                }
                else
                {
                    door.SetActive(true);
                    open = false;
                }
            }
            
        }

        if (magicinrange)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (!open)
                {
                    door.SetActive(false);
                    open = true;
                }
                else
                {
                    door.SetActive(true);
                    open = false;
                }
            }
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TECHGUY"))
        {
            techinrange = true;
        }
        if (other.gameObject.CompareTag("MAGICGUY"))
        {
            magicinrange = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TECHGUY"))
        {
            techinrange = false;
        }
        if (other.gameObject.CompareTag("MAGICGUY"))
        {
            magicinrange = false;
        }
    }
}
