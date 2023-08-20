using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width;
    [SerializeField] private int _height;
    [SerializeField] private float _cellSize;
    [SerializeField] private Transform _gridVisualPrefab;
    private Grid _grid;
    private void Awake() {
        _grid = new Grid(_width, _height, _cellSize);
        _grid.CreateGridVisual(_gridVisualPrefab);
    }
}
