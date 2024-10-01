using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorFinal : MonoBehaviour
{
    private Animator animator;
    public string animationName;  // Nome da animação a ser definida no Inspetor
    public GameObject textToDeactivate;  // Texto da HUD a ser desativado
    public GameObject textToActivate;    // Texto da HUD a ser ativado

    void Start()
    {
        // Obtém o componente Animator no próprio objeto
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other)
    {
        // Verifica se o objeto que colidiu tem a tag "Player"
        if (other.CompareTag("Player"))
        {
            // Toca a animação com o nome especificado no Inspetor
            animator.Play(animationName);

            // Desativa o texto da HUD
            if (textToDeactivate != null)
            {
                textToDeactivate.SetActive(false);
            }

            // Ativa o outro texto da HUD
            if (textToActivate != null)
            {
                textToActivate.SetActive(true);
            }
        }
    }
}