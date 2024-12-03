using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passos : MonoBehaviour
{
    public AudioSource footstepAudio; // O áudio de passos
    public AudioClip footstepClip;   // O som do passo
    public float stepDelay = 0.5f;   // Intervalo entre os sons de passos

    private bool isWalking = false;
    private float stepTimer = 0f;

    void Update()
    {
        // Verifica se alguma tecla de movimento foi pressionada
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            if (!isWalking)
            {
                isWalking = true;
                stepTimer = 0f; // Reseta o timer ao começar a andar
            }

            // Atualiza o timer para tocar o som em intervalos
            stepTimer += Time.deltaTime;
            if (stepTimer >= stepDelay)
            {
                PlayFootstepSound();
                stepTimer = 0f;
            }
        }
        else
        {
            isWalking = false; // Player parou de andar
        }
    }

    void PlayFootstepSound()
    {
        if (footstepAudio != null && footstepClip != null)
        {
            footstepAudio.PlayOneShot(footstepClip);
        }
    }
}