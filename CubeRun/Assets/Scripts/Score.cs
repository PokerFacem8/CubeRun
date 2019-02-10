using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform Player;
    public Text ScoreText;

    // Update is called once per frame
    void Update()
    {
        ScoreText.text = (Player.position.z - 8).ToString("0");
    }
}
