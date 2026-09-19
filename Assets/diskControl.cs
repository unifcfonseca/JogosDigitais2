using UnityEngine;

public class diskControl : MonoBehaviour
{
    private Rigidbody2D rb2d;   
    public AudioSource source; 
    public float maxSpeed = 10f;
    void GoBall(){                      
        rb2d.AddForce(new Vector2(1f, 250f));
    }

    void Start () {
        source = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    void OnCollisionEnter2D (Collision2D coll) {
        if (coll.gameObject.tag == "blockv"){
            gameManager.Score("vermelho");
            Destroy(coll.gameObject);  
        }
        if (coll.gameObject.tag == "blockv2"){
            gameManager.Score("verde");
            Destroy(coll.gameObject);  
        }
        if (coll.gameObject.tag == "blocka"){
            gameManager.Score("amarelo");
            Destroy(coll.gameObject);  
        }
        if (coll.gameObject.tag == "blockr"){
            gameManager.Score("roxo");
            Destroy(coll.gameObject);  
        }
        if(coll.collider.CompareTag("Player")){
            Vector2 vel;
            vel.x = rb2d.linearVelocity.x;
            vel.y = (rb2d.linearVelocity.y / 2) + (coll.collider.attachedRigidbody.linearVelocity.y / 3);
            rb2d.linearVelocity = vel;
        }
    }

    void ResetBall(){
        rb2d.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    // Reinicializa o jogo
    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (rb2d.linearVelocity.magnitude > maxSpeed)
        {
            rb2d.linearVelocity = rb2d.linearVelocity.normalized * maxSpeed;
        }
    }
}
