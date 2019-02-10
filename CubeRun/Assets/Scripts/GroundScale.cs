using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScale : MonoBehaviour
{

    public Transform Player;

    // Update is called once per frame
    void Update()
    {
        //Scale do Ground
        Vector3 newScale = new Vector3();
        newScale.Set(15, 1, Player.position.z + 142);

        Vector3 newPosiiton = new Vector3();
        newPosiiton.Set(0, 0, (Player.position.z + 142)/2);

        transform.localScale = newScale;
        transform.position = newPosiiton;

    }
}
