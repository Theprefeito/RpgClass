using System.Collections;
using UnityEditor;
using UnityEngine;

public class Personagem : MonoBehaviour
{
    [ SerializeField ]
    private string nome;
    [ SerializeField ]
    private string arma;
    [ SerializeField ]
    private string habilidade;
    [ SerializeField ]
   
    private string supremo;
    [SerializeField]

    private int poder;
    [SerializeField]

    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

    public void AtribuirArma(string arma)
    {
        this.arma = arma;
    }

    public string Arma()
    {
        return this.arma;
    }

    public void AtribuirHabilidade(string habilidade)
    {
        this.habilidade = habilidade;
    }

    public string Habilidade()
    {
        return this.habilidade;
    }

    public void AtribuirSupremo(string supremo)
    {
        this.supremo = supremo;
    }

    public string Supremo()
    {
        return this.supremo;
    }

    public void AtribuirPoder(int poder)
    {
        this.poder = poder;
    }

    public int Poder()
    {
        return this.poder;
    }





    void Start()
    {
        
    }
    void Update()
    {
        
    }
}