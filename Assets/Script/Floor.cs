using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Floor : MonoBehaviour
{
    [SerializeField] private GameObject _floorPrefab;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Player._Xpos > 0)
        {
            if (Player._Xpos % 100 == 0)
            {
                Instantiate(_floorPrefab, new Vector3(Player._Xpos + 100, 0, 0), Quaternion.identity);
                Debug.Log("床生成: " + (Player._Xpos + 100));
            }
        }
    }
}
