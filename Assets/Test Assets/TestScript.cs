using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [Header("References")]
    [SerializeField] private Camera _cam;
    [SerializeField] private MeshRenderer _quad;

    [Header("Materials")]
    [SerializeField] private Material _matOn;
    [SerializeField] private Material _matOff;
    private bool _chromakeyValue = true;

    public void QuitApp()
    {
        Application.Quit();
    }

    public void RandomizeCameraBackgroundColor()
    {
        _cam.backgroundColor = Random.ColorHSV();
    }

    public void ToogleChromaKey()
    {
        if(_chromakeyValue)
        {
            _quad.material = _matOff;
            _chromakeyValue = false;
        }
        else
        {
            _quad.material = _matOn;
            _chromakeyValue = true;
        }
    }
}
