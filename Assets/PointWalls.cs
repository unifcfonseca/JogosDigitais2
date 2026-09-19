using UnityEngine;
using UnityEngine.SceneManagement;                                                         


public class PointWalls : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "ball")
        {
            SceneManager.LoadScene("finish");
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
