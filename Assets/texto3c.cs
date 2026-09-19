using UnityEngine;
using UnityEngine.SceneManagement;                                                        

public class texto3c : MonoBehaviour
{
    public GUISkin layout;              // Fonte do placar
        public KeyCode throwBall = KeyCode.Space;    // joga bola


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width /2, Screen.height / 2 , 100, 100), "Arknoid");
        GUI.Label(new Rect(Screen.width /2, Screen.height / 2 - 100, 100, 100), "Pressione espaço para jogar!");
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(throwBall)) {             // Velocidade da Raquete para ir para cima
            SceneManager.LoadScene("nivel1");
        }
    }
}
