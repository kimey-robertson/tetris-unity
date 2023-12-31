using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoardFloorScript : MonoBehaviour
{
    public BlockSpawnScript blockSpawnScript;
    // Start is called before the first frame update
    void Start()
    {
        blockSpawnScript = FindObjectOfType<BlockSpawnScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("onTrigger");
        // Access the GameObject that has made the collision
        GameObject collidedObject = collision.gameObject;

        // Access the collidedObject's children
        Transform collidedObjectTrigger = collidedObject.transform.Find("Trigger");

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
 