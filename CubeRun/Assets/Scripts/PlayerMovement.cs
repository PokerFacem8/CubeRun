using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //Esta variavel corresponder ao Rigidbody Component do objecto. 
    public Rigidbody rbd;

    //Variaveis para alterar o valor da força.
    public float player_foward_force = 2500f;
    public float player_side_force = 15f;
    public float maxWidth = 7f;

    private float timeSpeedUp = 10f;
    private float timeBetweenSpeedUps = 10f;

    void start() {
        rbd = GetComponent<Rigidbody>();

        
       
    }

    //Usa-se FixedUpdate quando dentro desse método estamos a trabalhar com physics.
    void FixedUpdate()
    {
        if(player_foward_force <= 6000f)
        {
            if (Time.timeSinceLevelLoad >= timeSpeedUp)
            {
                player_foward_force += 500f;
                timeSpeedUp = Time.timeSinceLevelLoad + timeBetweenSpeedUps;
            }
        }
        
        //Add Foward Force.
        rbd.AddForce(0, 0, player_foward_force * Time.deltaTime);

        //Determina o x
        //Input.GetAxis("Horizontal") - obtem um valor entre -1 a 1 e permite usar a/d setas e controller.
        //Time.fixedDeltaTime - tempo de update.
        //player_side_force - speed.
        float x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * player_side_force;

        //É criado um vetor de (x,y,z) com a nova posição do rigidbody que é calculada através da sua posição antiga + x.
        Vector3 newPosition = rbd.position + Vector3.right * x;

        //Permite só usar valores dentro de um intervalo (-maxWidth, maxWidth).
        newPosition.x = Mathf.Clamp(newPosition.x, -maxWidth, maxWidth);

        //Altera a posição do rigidbody
        rbd.MovePosition(newPosition);

        /*VERSÃO ANTIGA SÓ FUNCIONA COM a/d
        //When pressing "d"/"a" it will add a Sideway Force.
        if (Input.GetKey("d"))
        {
            rbd.AddForce(player_side_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rbd.AddForce(-player_side_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        */

    }
}
