using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class IA : MonoBehaviour
{
    public float detectionRange = 10.0f;  // Distância para detectar o player
    public float speed = 3.5f;  // Velocidade de movimento da IA
    public Transform playerCamera;  // Referência à câmera do player (coloque no Inspetor)
    public float fieldOfView = 60f;  // Campo de visão do player para detectar se está olhando para a IA
    private Transform player;
    private NavMeshAgent agent;

    void Start()
    {
        // Encontrar o player pela tag "Player"
        player = GameObject.FindGameObjectWithTag("Player").transform;

        // Obtém o componente NavMeshAgent
        agent = GetComponent<NavMeshAgent>();

        // Define a velocidade do NavMeshAgent
        agent.speed = speed;
    }

    void Update()
    {
        if (player != null)
        {
            // Calcular a distância entre a IA e o player
            float distance = Vector3.Distance(transform.position, player.position);

            // Se o player estiver dentro do alcance de detecção
            if (distance <= detectionRange)
            {
                // Verificar se o player está olhando para a IA
                if (!IsPlayerLookingAtAI())
                {
                    // Se o player não estiver olhando, a IA se move
                    agent.SetDestination(player.position);
                }
                else
                {
                    // Se o player estiver olhando, a IA para
                    agent.ResetPath();  // Para o movimento do agente
                }
            }
        }
    }

    // Função para verificar se o player está olhando para a IA
    bool IsPlayerLookingAtAI()
    {
        Vector3 directionToAI = transform.position - playerCamera.position;
        float angle = Vector3.Angle(playerCamera.forward, directionToAI);

        // Verifica se a IA está dentro do campo de visão do player
        return angle < fieldOfView / 2f;
    }
}