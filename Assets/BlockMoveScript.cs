using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMoveScript : MonoBehaviour
{
    public float dropRate = 3;
    private float timer = 0;
    public GameObject Block;
    private GameLogicScript.GridCell CurrentGridCell { get; set; }
    private float[] GameBoardFloor = { -4.5f, -4.5f, -4.5f, -4.5f, -4.5f, -4.5f, -4.5f, -4.5f };



    // Start is called before the first frame update
    void Start()
    {
        //ThreeByOneRed = GameObject.FindGameObjectWithTag("ThreeByOneRed");

        // Access GameLogicScript
        GameLogicScript gameLogicScript = FindObjectOfType<GameLogicScript>();

        //Vector2 pointToFind = new Vector2(2.5f, 3.5f);
        //string foundId = gameLogicScript.FindCellId(pointToFind);
        //Debug.Log($"Id of the cell at ({pointToFind.x}, {pointToFind.y}): {foundId}");



    }

    // Update is called once per frame
    void Update()
    {
        GameLogicScript gameLogicScript = FindObjectOfType<GameLogicScript>();
        CurrentGridCell = gameLogicScript.FindGridCellByPosition(Block);
        int CurrentColumn = gameLogicScript.ExtractNumberFromGridCell(CurrentGridCell);
        

        // If blocks y position is more than the blocks columns current floor, move down
        //if (Block.transform.position.y > GameBoardFloor[CurrentColumn])
        //{
            if (timer < dropRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                MoveDown();
                timer = 0;
            }
        //}
        // Else set the GridCell as occupied
        //else
        //{
        //    Debug.Log("occupied else");
        //    gameLogicScript.SetGridCellOccupied(CurrentGridCell);
        //    GameBoardFloor[CurrentColumn] = CurrentGridCell.Position.y + 1;
        //}
        //Debug.Log(GameBoardFloor[CurrentColumn]);

        // Access BlockScript
        //BlockScript blockScript = GetComponent<BlockScript>();
        //if (blockScript != null)
        //{
        //    GameLogicScript.GridCell currentCell = blockScript.CurrentGridCell;
        //    if (currentCell != null)
        //    {
        //        // Use the current cell information
        //        Debug.Log($"Block is in cell {currentCell.Id}");
        //    }
        //}
    }

    void MoveDown()
    {
        //transform.Translate(Vector3.down, Space.World);
        Block.transform.position += Vector3.down;
    }

    [ContextMenu("Manually Move Down")]
    void ManuallyMoveDown()
    {
        Block.transform.position += Vector3.down;
    }

    [ContextMenu("Manually Move Left")]
    void ManuallyMoveLeft()
    {
        Block.transform.position += Vector3.left;
    }

    [ContextMenu("Manually Move Right")]
    void ManuallyMoveRight()
    {
        Block.transform.position += Vector3.right;
    }

    [ContextMenu("Manually Move Up")]
    void ManuallyMoveUp()
    {
        Block.transform.position += Vector3.up;
    }
}              