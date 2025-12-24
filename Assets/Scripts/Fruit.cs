using System;
using UnityEngine;

public class Fruit : MonoBehaviour
{
    public float destroyPosition;
    private GameManager gameManager;

    private void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }
    private void Update()
    {
        if (transform.position.y <= destroyPosition)
        {
            Destroy(gameObject);
            gameManager.life = gameManager.life - 1;
        }
        Debug.Log("Game running");
            
        
            
    }
}
