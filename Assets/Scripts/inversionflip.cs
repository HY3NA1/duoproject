using UnityEngine;

public class inversionflip : MonoBehaviour
{
    private bool techinrange;
    private bool magicinrange;
    private bool isinverted;
    public GameObject[] invertedobjs;
    public GameObject[] normalobjs;
    public GameObject invfilter;
    public GameObject bg;
    private inversionmanager manager;
    public int i;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        manager = GameObject.Find("InvManager").GetComponent<inversionmanager>();
        isinverted = manager.isinverted;
        invertedobjs = manager.invertedobjs;
        normalobjs = manager.normalobjs;
        invfilter.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        isinverted = manager.isinverted;
        if (techinrange)
        {
            if (Input.GetKeyDown(KeyCode.Alpha7))
            {
                Debug.Log("Invert");
                if (!isinverted)
                {
                    invfilter.SetActive(true);
                    bg.SetActive(false);
                    for (i = 0; i < invertedobjs.Length; i++) 
                    {
                        invertedobjs[i].SetActive(true);
                    }
                    for (i = 0; i < normalobjs.Length; i++)
                    {
                        normalobjs[i].SetActive(false);
                    }
                    manager.isinverted = true;

                }
                else if (isinverted)
                {
                    invfilter.SetActive(false);
                    bg.SetActive(true);
                    for (i = 0; i < invertedobjs.Length; i++)
                    {
                        invertedobjs[i].SetActive(false);
                    }
                    for (i = 0; i < normalobjs.Length; i++)
                    {
                        normalobjs[i].SetActive(true);
                    }
                    manager.isinverted=false;
                }
            }
            
        }

        if (magicinrange)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                if (!isinverted)
                {
                    invfilter.SetActive(true);
                    bg.SetActive(false);
                    for (i = 0; i < invertedobjs.Length; i++)
                    {
                        invertedobjs[i].SetActive(true);
                    }
                    for (i = 0; i < normalobjs.Length; i++)
                    {
                        normalobjs[i].SetActive(false);
                    }
                    manager.isinverted = true;

                }
                else if (isinverted)
                {
                    invfilter.SetActive(false);
                    bg.SetActive(true);
                    for (i = 0; i < invertedobjs.Length; i++)
                    {
                        invertedobjs[i].SetActive(false);
                    }
                    for (i = 0; i < normalobjs.Length; i++)
                    {
                        normalobjs[i].SetActive(true);
                    }
                    manager.isinverted = false;
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
