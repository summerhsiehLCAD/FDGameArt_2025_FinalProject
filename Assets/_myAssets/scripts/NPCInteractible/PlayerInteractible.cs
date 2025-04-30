using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractible : MonoBehaviour
{
    public GameObject pressE;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Debug.Log(other.gameObject.tag);
            pressE.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            pressE.SetActive(false);
        }
    }
}
