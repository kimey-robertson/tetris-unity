using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawnScript : MonoBehaviour
{
    public float spawnRate = 3;
    //private float timer = 0;
    public GameObject Block;
    private Color[] predefinedColors = {
        Color.red,
        Color.green,
        Color.blue,
        Color.yellow,
        Color.cyan,
        Color.magenta,
        new Color(1f, 0.5f, 0f), // Orange
    };
    public bool blockStopped = false;

    // Start is called before the first frame update
    void Start()
    {
        blockStopped = false;
        SpawnBlock();
    }

    // Update is called once per frame
    void Update()
    {
        if (blockStopped == true)
        { 
            SpawnBlock();
        }
    }

    void SpawnBlock()
    {
        Instantiate(Block, new Vector3(-3.5f, 9.5f, -1), transform.rotation);
        SetRandomColor(Block);
        blockStopped = false;

    }

    void SetRandomColor(GameObject block)
    {
        Color randomColor = predefinedColors[Random.Range(0, predefinedColors.Length)];
        block.GetComponent<SpriteRenderer>().color = randomColor;
    }

}
