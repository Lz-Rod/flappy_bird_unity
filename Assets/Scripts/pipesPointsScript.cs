using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesPointsScript : MonoBehaviour
{
    public gameControllerScript objController;

    void Start(){
        //ao iniciar a cena ele busca qualquer script quye tenha o gameControllerScript
        objController = FindObjectOfType<gameControllerScript>();
    }

    void OnTriggerEnter2D(Collider2D colisor){
        //cada vez que o player encostar no colisor dos pipes ele adiciona um ponto a varScore
        objController.varScore++;
        //aqui modifica o texto da UI para receber o valor da pontuação
        objController.scoreText.text = objController.varScore.ToString();
    }

}
