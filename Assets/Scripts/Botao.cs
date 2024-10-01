using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Botao : MonoBehaviour
{
    public string sceneName;  // Nome da cena para trocar, configurado no Inspetor

    // Função para ser chamada pelo botão
    public void ChangeScene()
    {
        // Troca para a cena especificada
        SceneManager.LoadScene(sceneName);
    }
}
