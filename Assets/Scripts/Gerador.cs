using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerador : MonoBehaviour
{
    private Animator animator;
    public string animationName;  // Nome da animação a ser definida no Inspetor

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
        }
    }
}
