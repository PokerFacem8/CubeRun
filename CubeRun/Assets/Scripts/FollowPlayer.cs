using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //Esta variavel corresponde ao componente Transform do player.
    public Transform Player;

    //Vector3 é um tipo de variavel que guarda 3 floats (x,y,z).
    public Vector3 Offset;

    // Update is called once per frame
    void Update()
    {
        //Este tranform corresponde ao componente transform que está no GameObject.
        transform.position = Player.position + Offset;
    }
}
