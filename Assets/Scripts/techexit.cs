using UnityEngine;
using UnityEngine.SceneManagement;

public class techexit : MonoBehaviour
{
    private bool techinrange;
    public bool Thasexited;
    private GameObject mecha;
    private magicexit otherdoor;
    public string[] scenes;
    public int scenenumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Thasexited = false;
        mecha = GameObject.Find("Mecha");
        otherdoor = GameObject.Find("magicdoor").GetComponent<magicexit>();

    }

    // Update is called once per frame
    void Update()
    {
        if (techinrange)
        {
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                Debug.Log("Tech has Exited");
                Destroy(mecha);
                Thasexited=true;
                if (Thasexited && otherdoor.Mhasexited) 
                {
                    Debug.Log("Exitworking");
                    SceneManager.LoadScene(scenes[scenenumber]);
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
    }
}
