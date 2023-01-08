using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Die : MonoBehaviour
{
    public LevelManager levelManager;
    void Start()
    {
       levelManager = FindObjectOfType<LevelManager> ();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ( other.name == "Player")
        {
            levelManager.RespawnPlayer();
        }
       
    }
}
