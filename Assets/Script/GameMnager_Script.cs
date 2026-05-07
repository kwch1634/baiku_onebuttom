using UnityEngine;

public class GameMnager_Script : MonoBehaviour
{
    [SerializeField] private GameObject _scoreUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _scoreUI.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(Player._isGameOver == true && Input.GetKeyDown(KeyCode.R))
        {
            Player._isGameOver = false;
            Debug.Log("リセット");
            Debug.Log("スコアは" + Player._score);
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
        }
    }
}
