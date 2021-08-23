using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    //Velocidade do movimento da câmera.
    public float speed = 0.1f;

    // Input.GetAxis captura o clique do jogador.
    void Update()
    {
    float MoveX = Input.GetAxis("Horizontal");
    float MoveZ = Input.GetAxis("Vertical");

    //Vector3 é um tipo que só existe na unity armazena:X,Y,Z.
    Vector3 movedirection = new Vector3(MoveX, 0.0f, MoveZ);

    //Aplica a variavel velocidade para podermos ter mais controle sobre.
    transform.position += movedirection * speed;
        
    }
}
