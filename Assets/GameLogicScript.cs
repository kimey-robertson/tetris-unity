using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogicScript : MonoBehaviour
{
    //public GameObject Red3;

    //public GameObject[] RedGroup;
    public float GameBoardFloor = -4.5f;

    // Start is called before the first frame update

    void Awake()
    {
        PopulateGrid();
    }

    void Start()
    {

        //RedGroup = GameObject.FindGameObjectsWithTag("Red");
        //ExtractNumberFromGridCell(grid[0]);
        //ExtractLetterFromGridCell(grid[0]);


    }
    // Update is called once per frame
    void Update()
    {
    }

    // The gridCell object
    public class GridCell
    {
        // Properties
        public string Id { get; }
        public Vector2 Position { get;  }
        public bool Occupied { get; set; }

        // Constructor
        public GridCell(string id, Vector2 position, bool occupied)
        {
            Id = id;
            Position = position;
            Occupied = occupied;
        }
    }

    public GridCell[] grid { get; private set; }

    public void PopulateGrid()
    {
        // Create an array of GridCell objects
        GridCell[] grid = new GridCell[]
        {

        // 0 cells
        new GridCell("a0", new Vector2(-3.5f, 4.5f), false),
        new GridCell("b0", new Vector2(-3.5f, 3.5f), false),
        new GridCell("c0", new Vector2(-3.5f, 2.5f), false),
        new GridCell("d0", new Vector2(-3.5f, 1.5f), false),
        new GridCell("e0", new Vector2(-3.5f, 0.5f), false),
        new GridCell("f0", new Vector2(-3.5f, -0.5f), false),
        new GridCell("g0", new Vector2(-3.5f, -1.5f), false),
        new GridCell("h0", new Vector2(-3.5f, -2.5f), false),
        new GridCell("i0", new Vector2(-3.5f, -3.5f), false),
        new GridCell("j0", new Vector2(-3.5f, -4.5f), false),

        // 1 cells
        new GridCell("a1", new Vector2(-2.5f, 4.5f), false),
        new GridCell("b1", new Vector2(-2.5f, 3.5f), false),
        new GridCell("c1", new Vector2(-2.5f, 2.5f), false),
        new GridCell("d1", new Vector2(-2.5f, 1.5f), false),
        new GridCell("e1", new Vector2(-2.5f, 0.5f), false),
        new GridCell("f1", new Vector2(-2.5f, -0.5f), false),
        new GridCell("g1", new Vector2(-2.5f, -1.5f), false),
        new GridCell("h1", new Vector2(-2.5f, -2.5f), false),
        new GridCell("i1", new Vector2(-2.5f, -3.5f), false),
        new GridCell("j1", new Vector2(-2.5f, -4.5f), false),

        // 2 cells
        new GridCell("a2", new Vector2(-1.5f, 4.5f), false),
        new GridCell("b2", new Vector2(-1.5f, 3.5f), false),
        new GridCell("c2", new Vector2(-1.5f, 2.5f), false),
        new GridCell("d2", new Vector2(-1.5f, 1.5f), false),
        new GridCell("e2", new Vector2(-1.5f, 0.5f), false),
        new GridCell("f2", new Vector2(-1.5f, -0.5f), false),
        new GridCell("g2", new Vector2(-1.5f, -1.5f), false),
        new GridCell("h2", new Vector2(-1.5f, -2.5f), false),
        new GridCell("i2", new Vector2(-1.5f, -3.5f), false),
        new GridCell("j2", new Vector2(-1.5f, -4.5f), false),

        // 3 cells
        new GridCell("a3", new Vector2(-0.5f, 4.5f), false),
        new GridCell("b3", new Vector2(-0.5f, 3.5f), false),
        new GridCell("c3", new Vector2(-0.5f, 2.5f), false),
        new GridCell("d3", new Vector2(-0.5f, 1.5f), false),
        new GridCell("e3", new Vector2(-0.5f, 0.5f), false),
        new GridCell("f3", new Vector2(-0.5f, -0.5f), false),
        new GridCell("g3", new Vector2(-0.5f, -1.5f), false),
        new GridCell("h3", new Vector2(-0.5f, -2.5f), false),
        new GridCell("i3", new Vector2(-0.5f, -3.5f), false),
        new GridCell("j3", new Vector2(-0.5f, -4.5f), false),

        // 4 cells
        new GridCell("a4", new Vector2(0.5f, 4.5f), false),
        new GridCell("b4", new Vector2(0.5f, 3.5f), false),
        new GridCell("c4", new Vector2(0.5f, 2.5f), false),
        new GridCell("d4", new Vector2(0.5f, 1.5f), false),
        new GridCell("e4", new Vector2(0.5f, 0.5f), false),
        new GridCell("f4", new Vector2(0.5f, -0.5f),  false),
        new GridCell("g4", new Vector2(0.5f, -1.5f), false),
        new GridCell("h4", new Vector2(0.5f, -2.5f), false),
        new GridCell("i4", new Vector2(0.5f, -3.5f), false),
        new GridCell("j4", new Vector2(0.5f, -4.5f), false),

        // 5 cells
        new GridCell("a5", new Vector2(1.5f, 4.5f), false),
        new GridCell("b5", new Vector2(1.5f, 3.5f), false),
        new GridCell("c5", new Vector2(1.5f, 2.5f), false),
        new GridCell("d5", new Vector2(1.5f, 1.5f), false),
        new GridCell("e5", new Vector2(1.5f, 0.5f), false),
        new GridCell("f5", new Vector2(1.5f, -0.5f), false),
        new GridCell("g5", new Vector2(1.5f, -1.5f), false),
        new GridCell("h5", new Vector2(1.5f, -2.5f), false),
        new GridCell("i5", new Vector2(1.5f, -3.5f), false),
        new GridCell("j5", new Vector2(1.5f, -4.5f), false),

        // 6 cells
        new GridCell("a6", new Vector2(2.5f, 4.5f), false),
        new GridCell("b6", new Vector2(2.5f, 3.5f), false),
        new GridCell("c6", new Vector2(2.5f, 2.5f), false),
        new GridCell("d6", new Vector2(2.5f, 1.5f), false),
        new GridCell("e6", new Vector2(2.5f, 0.5f), false),
        new GridCell("f6", new Vector2(2.5f, -0.5f), false),
        new GridCell("g6", new Vector2(2.5f, -1.5f), false),
        new GridCell("h6", new Vector2(2.5f, -2.5f), false),
        new GridCell("i6", new Vector2(2.5f, -3.5f), false),
        new GridCell("j6", new Vector2(2.5f, -4.5f), false),

        // 7 cells
        new GridCell("a7", new Vector2(3.5f, 4.5f), false),
        new GridCell("b7", new Vector2(3.5f, 3.5f), false),
        new GridCell("c7", new Vector2(3.5f, 2.5f), false),
        new GridCell("d7", new Vector2(3.5f, 1.5f), false),
        new GridCell("e7", new Vector2(3.5f, 0.5f), false),
        new GridCell("f7", new Vector2(3.5f, -0.5f), false),
        new GridCell("g7", new Vector2(3.5f, -1.5f), false),
        new GridCell("h7", new Vector2(3.5f, -2.5f), false),
        new GridCell("i7", new Vector2(3.5f, -3.5f), false),
        new GridCell("j7", new Vector2(3.5f, -4.5f), false),

        };

        this.grid = grid;

    }

    // Function to find the corresponding GridCell for a given position
    public GridCell FindGridCellByPosition(GameObject block)
    {
        //BlockScript blockScript = block.GetComponent<BlockScript>();
        Vector2 blockPosition = Vector2.zero;  // Declare blockPosition outside the if statement

        //if (blockScript != null)
        //{
        //    // Find the corresponding cell based on the block's position
        //    blockPosition = new Vector2(block.transform.position.x, block.transform.position.y);

        //    //blockScript.CurrentGridCell = FindGridCellByPosition(blockPosition);
        //    //Debug.Log(blockPosition);
            
        //}

        foreach (GridCell cell in grid)
        {
            if (Mathf.Approximately(cell.Position.x, blockPosition.x) && Mathf.Approximately(cell.Position.y, blockPosition.y))
            {
                return cell;
            }
        }
        return null; // or handle the case where no matching cell is found
    }

    // Function to extract the number from the GridCell's Id
    public int ExtractNumberFromGridCell(GridCell cell)
    {
        if (cell != null)
        {
            string id = cell.Id;
            // Assuming the format is always a letter followed by a number
            string numberPart = id.Substring(1);
            int number;
            if (int.TryParse(numberPart, out number))
            {
                return number;
            }
            else
            {
                Debug.LogError($"Failed to extract number from GridCell Id: {id}");
                return -1; // or handle the error as appropriate
            }
        }
        else
        {
            return 0;
        }
    }

    // Function to extract the letter from the GridCell's Id
    public char ExtractLetterFromGridCell(GridCell cell)
    {
        string id = cell.Id;

        // Assuming the format is always a letter followed by a number
        if (!string.IsNullOrEmpty(id) && char.IsLetter(id[0]))
        {
            return id[0];
        }
        else
        {
            Debug.LogError($"Failed to extract letter from GridCell Id: {id}");
            return '\0'; // or handle the error as appropriate
        }
    }

    // Function to set a GridCell's occupied property if there is a block in it.
    public void SetGridCellOccupied(GridCell cell)
    {
        if (cell != null)
        {
            cell.Occupied = true;
        }
        else
        {
            Debug.LogError("Attempted to set the occupied property for a null GridCell.");
        }
    }
}
