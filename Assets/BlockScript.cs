using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockScript : MonoBehaviour
{
    // Reference to the current grid cell
    //public GameLogicScript.GridCell CurrentGridCell { get; set; }
    private GameLogicScript gameLogicScript;
    private GameLogicScript.GridCell CurrentGridCell { get; set; }
    public GameObject Block;

    // Start is called before the first frame update
    void Start()
    {
        gameLogicScript = FindObjectOfType<GameLogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //CurrentGridCell = gameLogicScript.FindGridCellByPosition(Block);
        //gameLogicScript.ExtractNumberFromGridCell(CurrentGridCell);
        //gameLogicScript.ExtractLetterFromGridCell(CurrentGridCell);
    }
}
