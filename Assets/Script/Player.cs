using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("プレイヤー設定")]
    [SerializeField] private float _speed = 1.0f;
    [SerializeField] private float _jumpForce = 1.0f;
    

    //他スクリプトで使う
    public static float _Xpos;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(_speed * Time.deltaTime, 0f, 0f);
        _Xpos = transform.position.x;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * _jumpForce, ForceMode.Impulse);
        }
    }
}
