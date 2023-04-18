using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPipesScript : MonoBehaviour
{
    
    public GameObject objPipe;

    public float varHeight;
    public float varMaxTime;

    private float varTimer = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // esse game object recebe uma instancia do objPipe
        GameObject objNewPipe = Instantiate(objPipe);
        // aqui o objeto criado terá a posição no eixo y sorteado dentro da altura
        objNewPipe.transform.position = transform.position + new Vector3(0, Random.Range(-varHeight, varHeight), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(varTimer > varMaxTime){
            // esse game object recebe uma instancia do objPipe
            GameObject objNewPipe = Instantiate(objPipe);
            // aqui o objeto criado terá a posição no eixo y sorteado dentro da altura
            objNewPipe.transform.position = transform.position + new Vector3(0, Random.Range(-varHeight, varHeight), 0);
            // aqui destroi o cano após 5 segundos
            Destroy(objNewPipe, 5f);
            varTimer = 0;
        }

        varTimer += Time.deltaTime;
    }
}
