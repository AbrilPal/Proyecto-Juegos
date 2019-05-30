using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public SpriteRenderer renderer;
    public float SpeedUp = 4;
    public float Speed = 1;
    public float JumpSpeed = 2;
    public float Gravity = 1;
    private Rigidbody2D rb;
    private bool poweredUp = false;
    public Sprite powered;
    private float Velocity;
    private bool isBig = false;
    private float HorizontalDirection = 0;
    public Sprite[] Idle,walk;
    public Sprite[] BigIdle, BigWalk;
    private Sprite[] CurrentAnim;
    private int AnimState = -1;
    private float animClock;
    private static Transform p;
    private int CurrentSprite;
    public int monedas = 0;
    public AudioClip coin;
    public static Transform GetTransform()
    {
        return p;
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
   
    p = this.transform;
        SetAnim(0, isBig);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump") && rb)
        {
            rb.AddForce(new Vector2(0, 4), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.A))
        {
            //derecha
            HorizontalDirection = -1;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            HorizontalDirection = 1;
        }
        else
        {
            HorizontalDirection = 0;
        }
        Velocity = Mathf.MoveTowards(Velocity, HorizontalDirection, SpeedUp * Time.deltaTime);
        var pos = transform.position;
        pos.x+= (Speed * Velocity) * Time.deltaTime;
        if (HorizontalDirection == 1)
        {
            //derecha
            renderer.flipX = false;
        }else if (HorizontalDirection == -1)
        {
            renderer.flipX = true;
        }
        transform.position = pos;
        if (Velocity != 0)
        {
            //se esta moviendo
            SetAnim(1, isBig);
        }
        else
        {
            //ya no se mueve 
            SetAnim(0, isBig);
        }
        animClock += Time.deltaTime * (Mathf.Abs(Velocity)) * (Speed * 8);
        if (animClock >= 1)
        {
            CurrentSprite += 1;
            animClock = 0;
        }
        if(CurrentSprite>= CurrentAnim.Length)
        {
            CurrentSprite = 0;
        }
        renderer.sprite = CurrentAnim[CurrentSprite];
    }

    void SetAnim(int state, bool big)
    {
        if (state != AnimState)
        {
            CurrentSprite = 0;
            animClock = 0;
            //cuando no se mueve
            if(state==0 && !big) { CurrentAnim = Idle; }
            if (state == 1 && !big) { CurrentAnim = walk; }
            AnimState = state;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("malo"))
        {
            

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;
               
            }
        }

        if (collision.gameObject.CompareTag("malo1"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }

        if (collision.gameObject.CompareTag("malo3"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }

        if (collision.gameObject.CompareTag("malo4"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo5"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo6"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo7"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo8"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo9"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo10"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo11"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo12"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo13"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo14"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo15"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo16"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }
        if (collision.gameObject.CompareTag("malo17"))
        {

            if (!poweredUp)
            {
                Destroy(gameObject);
                Perdio1();
            }
            else
            {
                Destroy(collision.gameObject);
                poweredUp = false;

            }
        }

        else if (collision.gameObject.CompareTag("power"))
        {
            Destroy(collision.gameObject);
            poweredUp = true;
            GetComponent<SpriteRenderer>().sprite = powered;
        }

        if (collision.gameObject.CompareTag("moneda"))
        {
            GetComponent<AudioSource>().Play();
            monedas = monedas + 1;
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.CompareTag("caer"))
        {
            Perdio();
        }

        if (collision.gameObject.CompareTag("perder1"))
        {
            Perdio1();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("moneda"))
        {
            GetComponent<AudioSource>().Play();
            monedas = monedas + 1;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.CompareTag("win"))
        {
            Gano();
        }
        if (collision.gameObject.CompareTag("win1"))
        {
            End();
        }
    }

    public void Perdio()
    {

        SceneManager.LoadScene("perder");
    }

    public void Gano()
    {

        SceneManager.LoadScene("siguiente");
    }

    public void Perdio1()
    {

        SceneManager.LoadScene("perder1");
    }

    public void End()
    {

        SceneManager.LoadScene("finalMario");
    }
}

