using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GerenciadorDeCenas : MonoBehaviour
{
    public void Nivel01()
    {
        SceneManager.LoadScene("NivelFacil1");
    }    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Intro()
    {
        SceneManager.LoadScene("Intro");
    }
    public void Configs()
    {
        SceneManager.LoadScene("Configuracoes");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void Dificuldades()
    {
        SceneManager.LoadScene("Dificuldades");
    }
}
