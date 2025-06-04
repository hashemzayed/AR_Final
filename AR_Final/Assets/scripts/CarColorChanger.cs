using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarColorChanger : MonoBehaviour
{
    public Renderer carRenderer;
    public Color[] colors;
    private int currentColorIndex = 0;

    public void ChangeColor()
    {
        if (colors.Length == 0 || carRenderer == null)
            return;

        currentColorIndex = (currentColorIndex + 1) % colors.Length;
        carRenderer.material.color = colors[currentColorIndex];
    }
}