using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FieldGrid
{
    private int width, height;
    private float cellSize = 10f;
    private GameObject[,] field;

    public FieldGrid(int width, int height)
    {
        this.width = width;
        this.height = height;
        field = new GameObject[height, width];
    }

    public void PlaceUnit(int x, int y, GameObject unit)
    {
        field[x, y] = unit;
    }

    public GameObject GetUnit(int x, int y)
    {
        return field[x, y] != null ? field[x, y] : null;
    }

}
