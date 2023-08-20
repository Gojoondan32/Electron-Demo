using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GridVisual : MonoBehaviour
{
    [SerializeField] private TextMeshPro _text;

    public void SetText(GridPosition gridPosition){
        _text.text = gridPosition.x + "," + gridPosition.z;
    }
}
