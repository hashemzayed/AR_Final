using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public void LoadHomeScene()
    {
        SceneManager.LoadScene("StartMenu"); // replace with your actual home scene name
    }
}
