using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeletorDeEnigmas : MonoBehaviour
{
    [SerializeField] ListaDeEnigmas lista;
    void Start()
    {
        int index = Random.Range(0, lista.listaDeEnigmas.Count);
        Debug.Log(lista.listaDeEnigmas[index].pergunta);
        Debug.Log(lista.listaDeEnigmas[index].respostaCorreta);
        Debug.Log(lista.listaDeEnigmas[index].respostaErrada1);
        Debug.Log(lista.listaDeEnigmas[index].respostaErrada2);
        Debug.Log(lista.listaDeEnigmas[index].respostaErrada3);
        Debug.Log(lista.listaDeEnigmas[index].respostaErrada4);
    }
    
}
