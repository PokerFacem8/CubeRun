using UnityEngine;

public class Obstacle : MonoBehaviour
{

    private GameObject MainCamera;
    // Update is called once per frame
    void Update()
    {
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");

        if(transform.position.z < MainCamera.transform.position.z)
        {
            Destroy(gameObject);
        }
    }
}
