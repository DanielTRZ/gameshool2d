using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public LevelManager levelManager;

    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
    }


    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
      if (other.name == "Player")
        {
            levelManager.curCheckpoint = gameObject;
            Debug.Log("Activated Check" + transform.position);
        }
    }
}