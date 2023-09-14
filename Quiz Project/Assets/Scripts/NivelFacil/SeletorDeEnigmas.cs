using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeletorDeEnigmas : MonoBehaviour
{
    [SerializeField] ListaDeEnigmas lista;
    [SerializeField] Text perguntaTexto;
    [SerializeField] Text botaoResposta1Texto;
    [SerializeField] Text botaoResposta2Texto;
    [SerializeField] Text botaoResposta3Texto;
    [SerializeField] Text botaoResposta4Texto;
    [SerializeField] Text botaoResposta5Texto;
    public List<string> respostasPossiveis = new List<string>();
    public int index;
    public int indexRespostas;
    public int pontuacao = 0;

    void Start()
    {
        index = Random.Range(0, lista.listaDeEnigmas.Count);
        
        //populando a lista respostasPossiveis com as nossas respostas
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaCorreta);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada1);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada2);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada3);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada4);
        
        //criando um novo índice para pegar um elemento da lista anterior e setar a um botão 
        indexRespostas = Random.Range(0, respostasPossiveis.Count);
        
        perguntaTexto.text = lista.listaDeEnigmas[index].pergunta;
        
        //após atribuir um valor ao botão, vamos remover ele da lista para que o valor não se repita nos botões
        botaoResposta1Texto.text = respostasPossiveis[indexRespostas];
        Remove();
        Randomizar();
        
        botaoResposta2Texto.text = respostasPossiveis[indexRespostas];
        Remove();
        Randomizar();
        
        botaoResposta3Texto.text = respostasPossiveis[indexRespostas];
        Remove();
        Randomizar();
        
        botaoResposta4Texto.text = respostasPossiveis[indexRespostas];
        Remove();
        Randomizar();
        
        botaoResposta5Texto.text = respostasPossiveis[indexRespostas];
        Remove();
        
    }
    public void Remove() => respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
    public void Randomizar() => indexRespostas = Random.Range(0, respostasPossiveis.Count);
    
    public void OnClick(Text TextoBotao)
    {
        if (TextoBotao.text == lista.listaDeEnigmas[index].respostaCorreta)
        {
            lista.listaDeEnigmas.Remove(lista.listaDeEnigmas[index]);
            pontuacao++;
            Start();
        }
        else
        {
            if (pontuacao <= 0)
                pontuacao = 0;
            else
                pontuacao--;
            Start();   
        }
    }
    
}
