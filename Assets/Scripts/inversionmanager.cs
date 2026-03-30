using UnityEngine;

public class inversionmanager : MonoBehaviour
{
    public bool isinverted;
    public GameObject[] invertedobjs;
    public GameObject[] normalobjs;
    public int i;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isinverted = false;
        invertedobjs = GameObject.FindGameObjectsWithTag("inverted");
        normalobjs = GameObject.FindGameObjectsWithTag("normal");
        for (i = 0; i < invertedobjs.Length; i++)
        {
            invertedobjs[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

}

