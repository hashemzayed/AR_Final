using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARPlacementInitializer : MonoBehaviour
{
    public ARPlacementInteractable placementInteractable;

    void Start()
    {
        if (CarSelectionManager.selectedCarPrefab != null)
        {
            placementInteractable.placementPrefab = CarSelectionManager.selectedCarPrefab;
        }
        else
        {
            Debug.LogWarning("No car prefab selected from CarSelectionManager.");
        }
    }
}
