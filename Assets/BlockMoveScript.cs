using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockMoveScript : MonoBehaviour
{
    public float dropRate = 3;
    private float timer = 0;
    public GameObject Block;
    private float gameFloor = -4.5f;
    private float leftWall = -3.5f;
    private float rightWall = 3.5f;
    private bool blockLeftMove = false;
    private bool blockRightMove = false;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move down timer
        if (timer < dropRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            MoveDown();
            timer = 0;
        }

        // Check for arrow key input
        if (Input.GetKeyDown(KeyCode.LeftArrow) && Block.transform.position.x > leftWall && !blockLeftMove)
        {
            Block.transform.position = new Vector3(Block.transform.position.x - 1f, Block.transform.position.y, Block.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && Block.transform.position.x < rightWall && !blockRightMove)
        {
            Block.transform.position = new Vector3(Block.transform.position.x - -1f, Block.transform.position.y, Block.transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && Block.transform.position.y > gameFloor)
        {
            Debug.Log("down key press");
            Block.transform.position = new Vector3(Block.transform.position.x, Block.transform.position.y - 1f, Block.transform.position.z);
        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        // Access the GameObject that has made the collision
        GameObject collidedObject = collision.gameObject;

        // if collide object's x is more than the block's (ie its on the right), block right moving
        if (collidedObject.transform.position.x > Block.transform.position.x)
        {
            blockRightMove = true;
        }

        // if collide object's x is less than the block's (ie its on the left), block left moving
        if (collidedObject.transform.position.x < Block.transform.position.x)
        {
            blockLeftMove = true;
        }

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        // This basically just does the opposite of the OnTrigger, to re-allow movement once there's no longer a block on the left or right of it
        GameObject exitedObject = collision.gameObject;

        if (exitedObject.transform.position.x > Block.transform.position.x)
        {
            blockRightMove = false;
        }

        if (exitedObject.transform.position.x < Block.transform.position.x)
        {
            blockLeftMove = false;
        }
    }

    void MoveDown()
    {
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