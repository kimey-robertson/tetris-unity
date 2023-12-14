using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockTriggerScript : MonoBehaviour
{
    public GameObject Block;
    public BlockSpawnScript blockSpawnScript;
    // Start is called before the first frame update
    void Start()
    {
        blockSpawnScript = FindObjectOfType<BlockSpawnScript>();
    }

    // Update is called once per frame
    void Update()
    {
        // Move the object to the nearest 0.5 decimal place on both x and y coordinates
        float roundedX = Mathf.Round(Block.transform.position.x * 2.0f) / 2.0f;
        float roundedY = Mathf.Round(Block.transform.position.y * 2.0f) / 2.0f;

        // Check if the position needs adjustment
        if (roundedX != Block.transform.position.x || roundedY != Block.transform.position.y)
        {
            // Update the object's position
            Block.transform.position = new Vector3(roundedX, roundedY, Block.transform.position.z);
        }

        // Ensure that the z rotation is always adjusted to 0
        if (Block.transform.rotation.eulerAngles.z != 0f)
        {
            // Update the object's rotation
            Block.transform.rotation = Quaternion.Euler(Block.transform.rotation.eulerAngles.x, Block.transform.rotation.eulerAngles.y, 0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("onTrigger");
        // Access the GameObject that has made the collision
        GameObject collidedObject = collision.gameObject;

        // Access the collidedObject's children
        Transform collidedObjectTrigger = collidedObject.transform.Find("Trigger");

        // Turn off the collidedObject's Move Script
        collidedObject.GetComponent<BlockMoveScript>().enabled = false;

        // Tell Block Spawn Script that the block has stopped moving, so it can spawn another block
        Debug.Log("before");
        blockSpawnScript.blockStopped = true;
        Debug.Log("after");

        // Check if the trigger was found
        if (collidedObjectTrigger != null)
        {
            collidedObjectTrigger.gameObject.SetActive(true);
            Debug.Log("Trigger active");
        }
        else
        {
            Debug.LogError("Trigger not found on the collided object.");
        }
    }
}
