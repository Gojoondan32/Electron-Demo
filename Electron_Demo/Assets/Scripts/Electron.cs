using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electron : MonoBehaviour
{
    public void Attract(Vector3 targetPosition, Circuit_Wire nextWire){
        StartCoroutine(MoveToPosition(targetPosition + new Vector3(0, 0.25f, 0), nextWire));
    }

    private IEnumerator MoveToPosition(Vector3 targetPosition, Circuit_Wire nextWire){
        while(transform.position != targetPosition){
            //transform.position = Vector3.Lerp(transform.position, targetPosition + new Vector3(0, 0.25f, 0), 0.1f);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.001f);
            Debug.Log("Moving");
            yield return null;
        }
        ElectronHasArrivedAtNewWire(nextWire);
    }

    private void ElectronHasArrivedAtNewWire(Circuit_Wire nextWire){
        Debug.Log("Electron has arrived at new wire");
        nextWire.ReceiveElectron(this);
    }
}
