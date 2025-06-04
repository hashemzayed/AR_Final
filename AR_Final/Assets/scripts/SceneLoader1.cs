using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader1 : MonoBehaviour
{
    public void LoadMarkerScene()
    {
        SceneManager.LoadScene("SampleScene"); // <-- use the name of your marker scene
    }
}
