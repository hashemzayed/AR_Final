using UnityEngine;
using UnityEngine.SceneManagement;

public class CarSelector : MonoBehaviour
{
    // Drag your car prefab here in the Unity Inspector
    public GameObject carPrefabToSelect;

    // This method will be called when the button is clicked
    public void OnCarSelect()
    {
        // Store the selected car prefab in a global static manager
        CarSelectionManager.selectedCarPrefab = carPrefabToSelect;

        // Load the AR scene — make sure the name matches the scene exactly
        SceneManager.LoadScene("Markerless");
    }
}


