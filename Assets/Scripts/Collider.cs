using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D collider)
    {
        LevelManager levelManager = new LevelManager();
        levelManager.LoadNextLevel();
    }
}
