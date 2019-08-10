using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeckyRotation : MonoBehaviour
{
    public GameObject becky;
    public Player player1, player2;
    
    
    public void Update()
    {
            becky.GetComponent<SpriteRenderer>().flipX = (player1.score > player2.score);
    }
}
