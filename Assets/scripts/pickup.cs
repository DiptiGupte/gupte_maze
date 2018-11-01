using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

	// Use this for initialization
	void Start ()
    {
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVeritcal = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVeritcal);

        rb.AddForce(movement * speed);
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("bug_dipti"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
