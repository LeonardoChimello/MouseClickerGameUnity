using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMovement : MonoBehaviour
{
    //NavMesh serve para pegar a info de onde o jogador pode se movimentar.    
    NavMeshAgent agent;

    // Quando o programa inicia ele confere o navmesh.
    void Start()
    {
        agent = GetComponent<NavMeshAgent> ();    
    }
    
    // GetMouseButtonDown 0 = botão do meio do mouse 
    //                    1 = botão direito do mouse
    //                    2 = botão esquerdo do mouse.
    // 
    // raycasthit e uma posição que é enviada, pode ser 3d ou 2d.
    // quando o jogador clica com o direito a coordenada é enviada para o raycasthit e se está tudo correto ele volta para unity 
    // e move o player.

    void Update()
    {
        if(Input.GetMouseButtonDown(1))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
            if(Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                agent.SetDestination(hit.point);
            }
        }
    }
}
