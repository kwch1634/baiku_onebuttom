using UnityEngine;
using UnityEngine.UI;

public class Score_Script : MonoBehaviour
{
    public GameObject _scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        _scoreText.GetComponent<Text>().text = "Score: " + Player._score.ToString();
    }
}
