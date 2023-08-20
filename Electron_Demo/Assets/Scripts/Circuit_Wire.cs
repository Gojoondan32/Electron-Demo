using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Circuit_Wire : MonoBehaviour
{
    [SerializeField] private Electron _electronPrefab;

    private Electron _electron;
    [SerializeField] private Circuit_Wire _nextWire;
    [SerializeField] private Circuit_Wire _previousWire;

    private void Start() {
        CreateElectron();
    }

    private void CreateElectron(){
        _electron = Instantiate(_electronPrefab, transform.position + new Vector3(0, 0.25f, 0), Quaternion.identity);
    }

    public void NegativeElectricField(){
        // Push the electron to the next wire
        _electron?.Attract(_nextWire.transform.position, _nextWire);
    }

    public void ReceiveElectron(Electron electron){
        if(electron != null){
            NegativeElectricField();
        }
        _electron = electron;
    }

}
