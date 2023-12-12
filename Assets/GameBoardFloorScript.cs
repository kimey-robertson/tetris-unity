using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBoardFloorScript : MonoBehaviour
{
    //public BoxCollider2D boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnReachGameBoardFloor(GameObject block)
    {
 
        block.GetComponent<SpriteRenderer>().color = Color.green;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        OnReachGameBoardFloor(collision.gameObject);
    }


}
