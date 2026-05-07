using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("プレイヤー設定")]
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private float _jumpForce = 1.0f;
    

    //他スクリプトで使う
    public static float _Xpos;
    public bool _isGround;
    public static bool _isGameOver;
    public static int _score;
    [SerializeField] private GameObject _gameUI;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        _isGameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0f, 0f);
        _Xpos = transform.position.x;
        _score = (int)_Xpos;

        if (Input.GetKeyDown(KeyCode.Space) && _isGround == true)
        {
            rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
            _isGround = false;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            _isGround = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            Debug.Log("ゲームオーバー");
            _isGameOver = true;
            _gameUI.SetActive(true);
        }
    }
}
