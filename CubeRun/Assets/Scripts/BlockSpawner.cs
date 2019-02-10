using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform Player;
    public Transform[] SpawnPoints;
    public GameObject Obstacle;

    private float timeToSpawn = 0.1f;

    public float timeBetweenWaves = 2f;

    // Update is called once per frame
    void Update()
    {
       Vector3 newPositiom = new Vector3();
       newPositiom.Set(0, 1, Player.position.z + 131);//(0,1,0 + 131)(x,y,z)
       transform.position = newPositiom;

       if(Player.gameObject.GetComponent<PlayerMovement>().player_foward_force == 4000f)
       {
            timeBetweenWaves = 1f;
       }

       if (Time.timeSinceLevelLoad >= timeToSpawn)
       {
           SpawnObstacle();
           timeToSpawn = Time.timeSinceLevelLoad + timeBetweenWaves;
       }
    }

    void SpawnObstacle()
    {
       int randomIndex = Random.Range(0, SpawnPoints.Length);

       for (int i = 0; i < SpawnPoints.Length; i++)
       {
           if (randomIndex != i)
           {
               Instantiate(Obstacle, SpawnPoints[i].position, Quaternion.identity);
           }
       }
    }
}
