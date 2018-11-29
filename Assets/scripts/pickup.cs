using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickup : MonoBehaviour {

    public float speed;
    public Text countText;

    public int count;

	// Use this for initialization
	void Start ()
    {
        count = 0;
        SetCountText(0);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("pickup"))
        {
            other.gameObject.SetActive(false);
            SetCountText(5);
        }
        if (other.gameObject.CompareTag("comp"))
        {
            other.gameObject.SetActive(false);
            SetCountText(10);
        }
        if (other.gameObject.CompareTag("button"))
        {
            other.gameObject.SetActive(false);
            SetCountText(50);
        }
    }

    void SetCountText(int point)
    {
        count = count + point;
        countText.text = "Pixel Points: " + count.ToString();
    }
}
