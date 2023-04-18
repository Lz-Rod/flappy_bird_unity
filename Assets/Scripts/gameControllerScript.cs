using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameControllerScript : MonoBehaviour
{

    public int varScore;
    public Text scoreText;

    void Start(){
        //despausa o game ao clicar no botão play da tela de game over
        Time.timeScale = 1;
    }

    public void RestartGame(){
        //esse método reinicia o jogo
        SceneManager.LoadScene(0);
    }
}
