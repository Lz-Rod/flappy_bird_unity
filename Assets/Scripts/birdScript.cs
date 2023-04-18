using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdScript : MonoBehaviour
{
    public float varSpeed = 1f;
    private Rigidbody2D varRig;

    public GameObject objGameOver;

    // Start is called before the first frame update
    void Start()
    {
        // Faz a variavel varRig receber os parametros do componente RigidBody2D
        varRig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Aqui faz o passarinho manipular o vetor up ao botão esquerdo do mouse ser clicado
        if(Input.GetMouseButtonDown(0)){
            varRig.velocity = Vector2.up * varSpeed;
        }
    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        // quando o bird colidir com um objeto a camada da UI gameover é ativa e o game é pausado
        objGameOver.SetActive(true);
        Time.timeScale = 0;
    }
}
