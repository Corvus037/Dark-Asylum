using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneOnKeyPress : MonoBehaviour
{
    public string sceneName;  // Nome da cena para a qual deseja mudar

    void Update()
    {
        // Verifica se a tecla Q foi pressionada
        if (Input.GetKeyDown(KeyCode.Q))
        {
            // Carrega a cena especificada
            SceneManager.LoadScene(sceneName);
        }
    }
}
