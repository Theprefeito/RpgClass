using UnityEngine;

public class Teste : MonoBehaviour
{
    Personagem Paladino = new Personagem();
    Personagem Malvado = new Personagem();


    void Start()
    {
        Paladino.AtribuirNome("Fuleco");
        Paladino.AtribuirArma("Espada Sagrada");
        Paladino.AtribuirHabilidade("Cura");
        Paladino.AtribuirSupremo("Luz Divina");
        Paladino.AtribuirPoder(50);

        Debug.Log("O Personagem se chama " + Paladino.Nome() + " , possui uma " + Paladino.Arma() + " , tem a habilidade de " + Paladino.Habilidade() + " e tem como habilidade especial " + Paladino.Supremo() + ". Esse conjunto de características totaliza " + Paladino.Poder() + " de poder");


        Malvado.AtribuirNome("Palhaço");
        Malvado.AtribuirArma("Espada comum");
        Malvado.AtribuirHabilidade("Arrebatar");
        Malvado.AtribuirSupremo("Strike");
        Malvado.AtribuirPoder(35);

          if (Malvado.Poder() >= Paladino.Poder())
        {
            Debug.Log("O " + Paladino.Nome() + " Não deveria aceitar essa luta");
        }
        else
        {
            Debug.Log("O " + Paladino.Nome() + " Continua invicto com "+ Paladino.Poder() + " de poder.");
        }

    }



    void Update()
    {
        
    }
}
