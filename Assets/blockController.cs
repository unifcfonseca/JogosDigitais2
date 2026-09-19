using UnityEngine;

public class blockController : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "ball")
        {
            gameManager.Score("vermelho");
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
