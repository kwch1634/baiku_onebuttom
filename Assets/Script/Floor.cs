using UnityEditor.Search;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;


public class Floor : MonoBehaviour
{
    [SerializeField] private GameObject _floorPrefab;
    [SerializeField] private GameObject _StartFloorPrefab;
    private float _CloneFloorXPos = 0f;

    private float lastGeneratedX = -100f;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(_StartFloorPrefab, new Vector3(50, 0, -7), Quaternion.identity);
        _CloneFloorXPos = 50 + 50;
    }

    // Update is called once per frame
    void Update()
    {
        if (Player._Xpos > 0)
        {
            int currentX = (int)Player._Xpos;
            if (currentX % 50 == 0 && currentX % 100 != 0 && currentX != lastGeneratedX)
            {
                GameObject _CloneFloor = Instantiate(_floorPrefab, new Vector3(_CloneFloorXPos + 50, 0, -7), Quaternion.identity);
                 Debug.Log("床生成: " + _CloneFloor.transform.position.x);
                _CloneFloorXPos = _CloneFloor.transform.position.x + 50;
                lastGeneratedX = currentX;
            }
        }
    }
}
