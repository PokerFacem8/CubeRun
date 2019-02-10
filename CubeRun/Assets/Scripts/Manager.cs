using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Manager : MonoBehaviour
{
    private PlayerMovement movement;
    private float slowdownFactor;
    private GameObject player;


    public void EndGame(PlayerMovement movement, float slowdownFactor, GameObject player)
    {
        this.movement = movement;
        this.slowdownFactor = slowdownFactor;
        this.player = player;

        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        //Antes de 1 segundo.

        player.GetComponent<Renderer>().material.color = Color.blue;
        movement.enabled = false;

        //Determina a escala a que o tempo decorre 1 = realtime / 0.5 = 2x Slower /0 = Frozen.
        Time.timeScale = slowdownFactor;

        yield return new WaitForSeconds(1f);
       
        //Depois de 1 segundo.
        
        //Dá load a uma Scene.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
