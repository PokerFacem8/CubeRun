using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public float slowdownFactor = 0.7f;
    public GameObject GameManager;

    private Manager manager;

    //É um método que utiliza o Rigidbody e Box Colider e que executa o seu código quando é detetada uma colisão.
    //O parametro collisionInfo serve para dizer-mos ao Unity que queremos informação sobre a collision.
    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log(collisionInfo.collider.tag);
        if (collisionInfo.collider.tag == "Obstacle")
        {
            if (GameManager.GetComponent<Manager>() != null)
            {
                manager = GameManager.GetComponent<Manager>();
                manager.EndGame(movement,slowdownFactor,this.gameObject);
            }
        }
    }
}
