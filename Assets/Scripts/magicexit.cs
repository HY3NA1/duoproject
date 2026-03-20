using UnityEngine;

public class magicexit : MonoBehaviour
{
    private bool magicinrange;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (magicinrange)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Magic has Exited");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MAGICGUY"))
        {
            magicinrange = true;
        }
    }

}
