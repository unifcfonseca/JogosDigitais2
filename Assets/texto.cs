using UnityEngine;

public class texto : MonoBehaviour
{
    public GUISkin layout;              // Fonte do placar

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width /2, Screen.height / 2 , 100, 100), "Você Ganhou");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
