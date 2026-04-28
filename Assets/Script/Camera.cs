using UnityEngine;

public class Camera : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Player._Xpos + 2, transform.position.y, transform.position.z); 
    }
}
