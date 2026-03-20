using Unity.VisualScripting;
using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject door;
    private bool techonbutton;
    private bool magiconbutton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (techonbutton || magiconbutton)
        {
            door.SetActive(false);
        }
        if (!techonbutton && !magiconbutton)
        {
            door.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TECHGUY"))
        {
            techonbutton = true;
        }
        if (other.gameObject.CompareTag("MAGICGUY"))
        {
            magiconbutton = true;
        }

    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("TECHGUY"))
        {
            techonbutton = false;
        }
        if (other.gameObject.CompareTag("MAGICGUY"))
        {
            magiconbutton = false;
        }
    }
}
