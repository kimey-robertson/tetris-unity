using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawnScript : MonoBehaviour
{
    public float spawnRate = 3;
    private float timer = 0;
    public GameObject Red;
    public GameObject Green;
    private List<GameObject> allBlocks = new List<GameObject>();
    private System.Random random = new System.Random();

    // Start is called before the first frame update
    void Start()
    {
        //SpawnBlock();

        // Add all the block to the list
        allBlocks.Add(Red);
        allBlocks.Add(Green);

    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            SpawnBlock();
            timer = 0;
        }
    }

    void SpawnBlock()
    {
        GameObject randomBlock = GetRandomBlock();

        Instantiate(randomBlock, new Vector3(-3.5f, 4.5f, -1), transform.rotation);

    }

    GameObject GetRandomBlock()
    {
        // Check if the list is not empty
        if (allBlocks.Count > 0)
        {
            // Generate a random index
            int randomIndex = random.Next(0, allBlocks.Count);

            // Return the GameObject at the random index
            return allBlocks[randomIndex];
        }
        else
        {
            // Handle the case where the list is empty
            Debug.LogWarning("The list of blocks is empty.");
            return null; // or some default GameObject
        }
    }
}
