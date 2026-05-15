using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;


public class Floor : MonoBehaviour
{
    [SerializeField] private GameObject _floorPrefab;
    [SerializeField] private GameObject _StartFloorPrefab;

    private float lastGeneratedX = -100f;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(_StartFloorPrefab, new Vector3(50, 0, -7), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player._Xpos > 0)
        {
            int currentX = (int)Player._Xpos;
            if (currentX % 50 == 0 && currentX % 100 != 0 && currentX != lastGeneratedX)
            {
                Instantiate(_floorPrefab, new Vector3(Player._Xpos + 100, 0, -7), Quaternion.identity);
                Debug.Log("床生成: " + (Player._Xpos + 100));
                lastGeneratedX = currentX;
            }
        }
    }
}
