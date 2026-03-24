using UnityEngine;
using UnityEngine.SceneManagement;

public class magicexit : MonoBehaviour
{
    private bool magicinrange;
    public bool Mhasexited;
    private GameObject witch;
    private techexit otherdoor;
    public string[] scenes;
    public int scenenumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mhasexited = false;
        witch = GameObject.Find("Witch");
        otherdoor = GameObject.Find("techdoor").GetComponent<techexit>();

    }

    // Update is called once per frame
    void Update()
    {
        if (magicinrange)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                Debug.Log("Magic has Exited");
                Destroy(witch);
                Mhasexited = true;
                if (Mhasexited && otherdoor.Thasexited)
                {
                    Debug.Log("Exitworking");
                    SceneManager.LoadScene(scenes[scenenumber]);
                }
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
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MAGICGUY"))
        {
            magicinrange = false;
        }
    }
}
