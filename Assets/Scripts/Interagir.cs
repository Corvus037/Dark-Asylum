using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interagir : MonoBehaviour
{
    public float interactionDistance = 3.0f;  // Distância máxima para interagir
    private GameObject player;

    void Start()
    {
        // Encontrar o player com a tag "Player"
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        if (player != null)
        {
            // Verificar a distância entre o player e o objeto
            float distance = Vector3.Distance(player.transform.position, transform.position);
            
            if (distance <= interactionDistance && Input.GetKeyDown(KeyCode.E))
            {
                // Desativa o objeto quando a tecla E é pressionada e o player está perto o suficiente
                gameObject.SetActive(false);
            }
        }
    }
}