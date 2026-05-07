using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    [SerializeField] private Button _button;

    void Start()
    {
        _button.onClick.AddListener(() => OnClickButton01());
    }
   public void OnClickButton01()
    {
        Player._isGameOver = false;
        Debug.Log("リセット");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
