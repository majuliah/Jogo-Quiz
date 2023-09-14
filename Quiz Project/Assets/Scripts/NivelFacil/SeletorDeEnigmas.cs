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
    [SerializeField] Text pontuacaoTexto;
    public List<string> respostasPossiveis = new List<string>();
    public int index;
    public int indexRespostas;
    public int pontuacao = 0;

    void Start()
    {
        pontuacaoTexto.text = pontuacao.ToString();
        index = Random.Range(0, lista.listaDeEnigmas.Count);
        
        //populando a lista respostasPossiveis com as nossas respostas
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaCorreta);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada1);
        respostasPossiveis.Add(lista.listaDeEnigmas[index].respostaErrada2);
        
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
        
    }
    public void Remove() => respostasPossiveis.Remove(respostasPossiveis[indexRespostas]);
    public void Randomizar() => indexRespostas = Random.Range(0, respostasPossiveis.Count);
    
    public void OnClick(Text TextoBotao)
    {
        if (TextoBotao.text == lista.listaDeEnigmas[index].respostaCorreta)
        {
            lista.listaDeEnigmas.Remove(lista.listaDeEnigmas[index]);
            pontuacao++;
            pontuacaoTexto.text = pontuacao.ToString();
            Start();
        }
        else
        {
            if (pontuacao <= 0)
            {
                pontuacao = 0;
                pontuacaoTexto.text = pontuacao.ToString();
            }
            else
            {
                pontuacao--;
                pontuacaoTexto.text = pontuacao.ToString();
            }
            Start();   
        }
    }
    
}
