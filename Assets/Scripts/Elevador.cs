using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  

public class ChangeSceneOnInteract : MonoBehaviour
{
    public string sceneName;  
    public float interactionRange = 3.0f; 
    private Transform player;

    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        
        float distance = Vector3.Distance(player.position, transform.position);

        
        if (distance <= interactionRange && Input.GetKeyDown(KeyCode.E))
        {
            
            SceneManager.LoadScene(sceneName);
        }
    }
}
