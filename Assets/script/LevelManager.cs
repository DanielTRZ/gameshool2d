using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    private Player player;
    public GameObject curCheckpoint;
   
    void Start()
    {
        player = FindObjectOfType<Player> ();
    }

 
    void Update()
    { 
    }

    
     public void RespawnPlayer()
    {
        Debug.Log("Player Respawn");
        player.transform.position = curCheckpoint.transform.position;
    }
}
