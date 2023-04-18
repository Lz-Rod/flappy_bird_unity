using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipesScript : MonoBehaviour
{
    // variaveis
    public float varSpeed;

    // Update is called once per frame
    void Update()
    {
        //faz os canos se movimentarem ao atribuir uma posição a cada frame
        transform.position += Vector3.left * varSpeed * Time.deltaTime;
    }
}
