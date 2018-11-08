using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

    public float speed;
    private Rigidbody rb;
    private int bugCount;
    private int compCount;
    private int buttonCount;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
        bugCount = 0; 
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            bugCount = bugCount + 5;
        }
        else if (other.gameObject.CompareTag("comp"))
        {
            other.gameObject.SetActive(false);
            compCount = compCount + 10;
        }
        else if (other.gameObject.CompareTag("button"))
        {
            other.gameObject.SetActive(false);
            buttonCount = buttonCount + 1;
        }
    }
}
