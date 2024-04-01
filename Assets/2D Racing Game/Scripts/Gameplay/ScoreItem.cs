using UnityEngine;
using System.Collections;


public enum ScoreType
{
    Coin,
    Fuel
}

public class ScoreItem : MonoBehaviour
{
    //Score-----------------------------------------------
    public int Score = 100;

    //Start-----------------------------------------------
    void Start()
    {
        trans = GetComponent<Transform>();
        man = GameObject.FindObjectOfType<GameManager>();
        sprite = GetComponent<SpriteRenderer>();
    }

    //Score Type------------------------------------------
    public ScoreType type;

    //------------------------------------------
//Manager-----------------------------------------------
    GameManager man;

    //Sprite renderer for fade-----------------------------------------------
    SpriteRenderer sprite;
    //-----------------------------------------------

    //Move up vector-----------------------------------------------
    public Vector3 Up__Vector3 = new Vector3(0, 7f, 0);

    public float speed = 2.3f, FadeSpeed = 2.3f;

    //-----------------------------------------------
    Transform trans;


    //trigger-----------------------------------------------
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("CoinTrigger"))
        {
            if (type == ScoreType.Coin)
                man.AddCoin(Score);
            if (type == ScoreType.Fuel)
                man.AddFuel(100);


            canCompute = true;
            Fade = true;
        }
    }


    // Internal usage
    public bool canCompute;
    bool Fade;

    void Update()
    {
        if (canCompute)
        {
            if (Fade)
            {
                trans.Translate(Up__Vector3 * Time.deltaTime * speed);

                if (sprite.material.color.a > 0)
                {
                    sprite.material.color = new Color(1f, 1f, 1f, sprite.material.color.a - FadeSpeed * Time.deltaTime);
                }
                else
                    Destroy(gameObject);
            }
        }
    }
}