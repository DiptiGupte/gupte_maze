using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class endGame : MonoBehaviour {

    public void end()
    {
        SceneManager.LoadScene("title screen");
    }
}