using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid 
{
    private int _width;
    private int _height;
    private float _cellSize;
    private GridPosition[,] _gridArray;

    public Grid(int width, int height, float cellSize){
        _width = width;
        _height = height;
        _cellSize = cellSize;

        _gridArray = new GridPosition[_width, _height];

        CreateGrid();
    }

    private void CreateGrid(){
        for (int x = 0; x < _gridArray.GetLength(0); x++){
            for (int z = 0; z < _gridArray.GetLength(1); z++){
                _gridArray[x, z] = new GridPosition(x, z);
            }
        }
    }

    public GridPosition GetGridPosition(Vector3 worldPosition){
        int x = Mathf.FloorToInt(worldPosition.x / _cellSize);
        int z = Mathf.FloorToInt(worldPosition.z / _cellSize);

        return _gridArray[x, z];
    }

    public Vector3 GetWorldPosition(GridPosition gridPosition){
        return new Vector3(gridPosition.x, 0, gridPosition.z) * _cellSize;
    }


    public void CreateGridVisual(Transform gridVisualPrefab){
        for (int x = 0; x < _gridArray.GetLength(0); x++){
            for (int z = 0; z < _gridArray.GetLength(1); z++){
                GridPosition gridPosition = _gridArray[x, z];
                Vector3 worldPosition = GetWorldPosition(gridPosition);

                Transform gridVisual = GameObject.Instantiate(gridVisualPrefab, worldPosition, Quaternion.identity);
                gridVisual.GetComponent<GridVisual>().SetText(gridPosition);                
            }
        }
    }
}
