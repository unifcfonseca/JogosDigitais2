using UnityEngine;

public class player2Control : MonoBehaviour
{
    public KeyCode moveLeft = KeyCode.A;      // Move a raquete para esquerda
    public KeyCode moveRight = KeyCode.D;    // Move a raquete para direita
    public KeyCode throwBall = KeyCode.Space;    // joga bola
    public float speed = 10.0f;             // Define a velocidade da raquete
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete
    public float boundX = 8f; 
    public bool throwed = false;
    GameObject theBall;                 // Referência ao objeto bola

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        theBall = GameObject.FindGameObjectWithTag("ball"); // Busca a referência da bola

    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb2d.linearVelocity;                // Acessa a velocidade da raquete
        if (Input.GetKey(moveLeft)) {             // Velocidade da Raquete para ir para cima
            vel.x = -speed;
        }
        else if (Input.GetKey(moveRight)) {      // Velocidade da Raquete para ir para cima
            vel.x = speed;                    
        }
        else {
            vel.x = 0;                          // Velociade para manter a raquete parada
        }
        if (Input.GetKey(throwBall) && !throwed) {             // Velocidade da Raquete para ir para cima
            theBall.SendMessage("GoBall", null, SendMessageOptions.RequireReceiver);
            throwed = true;
        }
        rb2d.linearVelocity = vel;                    // Atualizada a velocidade da raquete


        var pos = transform.position;           // Acessa a Posição da raquete

        if (pos.x > boundX) {                  
            pos.x = boundX;                     
        }
        else if (pos.x < -boundX) {
            pos.x = -boundX;                   
        }
        transform.position = pos;     

        
    }
}
