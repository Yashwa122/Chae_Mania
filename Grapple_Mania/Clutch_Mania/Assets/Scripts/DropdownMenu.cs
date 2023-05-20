using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class DropdownMenu : MonoBehaviour
{
    public TMP_Dropdown dropdown;
    private Volume vol;
    private Colourblind cb;

    private void Start()
    {
        vol = GameObject.Find("ColorVolume").GetComponent<Volume>();
        cb = GameObject.Find("ColorVolume").GetComponent<Colourblind>();
    }

    public void HandleInputData(int val)
    {
        if (val == 0)
        {
            //Normal Vision
            cb.mode = Modes.Normal;
        }

        if (val == 1)
        {
            //Protanopia
            cb.mode = Modes.Protanopia;
        }

        if (val == 2)
        {
            //Protanomaly
            cb.mode = Modes.Protanomaly;
        }

        if (val == 3)
        {
            //Deuteranopia
            cb.mode = Modes.Deuteranopia;
        }

        if (val == 4)
        {
            //Deuteranomaly
            cb.mode = Modes.Deuteranomaly;
        }

        if (val == 5)
        {
            //Tritanopia
            cb.mode = Modes.Tritanopia;
        }

        if (val == 6)
        {
            //Tritanomaly
            cb.mode = Modes.Tritanomaly;
        }

        if (val == 7)
        {
            //Achromatopsia
            cb.mode = Modes.Achromatopsia;
        }

        if (val == 8)
        {
            //Achromanomaly
            cb.mode = Modes.Achromatomaly;
        }
    }
}
