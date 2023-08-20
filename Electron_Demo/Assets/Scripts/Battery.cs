using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

// This class should do two functions:
// 1. Take electrons from the previous wire if there is one
// 2. Release electrons to the next wire if there is one

public class Battery : MonoBehaviour
{
    [SerializeField] private Circuit_Wire _nextWire;
    [SerializeField] private Circuit_Wire _previousWire;
    private Electron _electron;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void TakeElectron(){
        
    }
    private void ReleaseElectron(){
        _nextWire.NegativeElectricField();
    }
}
