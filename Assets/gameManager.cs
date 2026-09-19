using UnityEngine;
using UnityEngine.SceneManagement;                                                        


public class gameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static int PlayerScore1 = 0; // Pontuação do player 1
    public float total = -1;
    public GUISkin layout;              // Fonte do placar
    GameObject theBall;                 // Referência ao objeto bola
    void Start()
    {
        theBall = GameObject.FindGameObjectWithTag("ball"); // Busca a referência da bola

    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    public static void Score (string corID) {
        if (corID == "vermelho")
        {
            PlayerScore1 = PlayerScore1 + 10;
        }
        if (corID == "verde")
        {
            PlayerScore1 = PlayerScore1 + 20;
        }
        if (corID == "amarelo")
        {
            PlayerScore1 = PlayerScore1 + 30;
        }
        if (corID == "roxo")
        {
            PlayerScore1 = PlayerScore1 + 40;
        }
    }

    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(100, Screen.height / 2 + 150, 100, 100), "" + PlayerScore1);

    }

    // Update is called once per frame
    void Update()
    {
        Scene scene = SceneManager.GetActiveScene();
        GameObject[] gos = GameObject.FindGameObjectsWithTag("blockv");
        GameObject[] gos1 = GameObject.FindGameObjectsWithTag("blockv2");
        GameObject[] gos2 = GameObject.FindGameObjectsWithTag("blocka");
        GameObject[] gos3 = GameObject.FindGameObjectsWithTag("blockr");
        total = gos.Length + gos1.Length + gos2.Length + gos3.Length;
        print(gos.Length);
        if(total == 0){
            if (scene.name == "nivel1"){
                SceneManager.LoadScene("nivel2");
            } else if(scene.name == "nivel2"){
                SceneManager.LoadScene("nivel3");
            } else if(scene.name == "nivel3"){
                SceneManager.LoadScene("finish2");
            }
        }
    }

}
