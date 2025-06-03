using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadMarkerlessHomeScene()
    {
        Debug.Log("Loading HomeUI scene...");  // Helps test if button is triggered
        SceneManager.LoadScene("HomeUI"); // Match this name with your actual Home Scene!
    }
}
