using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{

    public GameObject player;

    private Rigidbody2D rb;

    public Vector2 enemyVec;
    private Vector2 enemyOrigPos;

    public AudioSource deathSFSource;
    public AudioClip deathClip;
    public float maximumSpeed;

    private bool NIGHTCLUB;
    private bool death;
    public Color targetColor;
    public float enemySpeed;
    public float speedGrowthFactor;
    public float timeLeft;
    private float currrentTime;
    private float direction;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        enemyOrigPos = rb.transform.position;
        if (!player.GetComponent<Player>().getHighSpeed()) {
            enemySpeed = 1;
        } else
        {
            enemySpeed = player.GetComponent<Player>().getSpeed() / 5;
        }
        maximumSpeed = 100;
        direction = 1;
        speedGrowthFactor = 1.7f;
        death = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float vol = Random.Range(0.1f, 0.3f);
        NIGHTCLUB = (PlayerPrefs.GetInt("NightClub") != 0);
        if (collision.gameObject.CompareTag("Player"))
        {
            death = true;
            
            if (currrentTime > 5 + Random.Range(0, 5f))

            {
                deathSFSource.PlayOneShot(deathClip, vol);

                currrentTime = 0;
            }

        }
        else if (collision.gameObject.CompareTag("Enemy"))
        {
            death = (death || collision.gameObject.GetComponent<EnemyScript>().getDeath());
        }
        else if (collision.gameObject.CompareTag("Wall"))
        {
            tempReverse();
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Remover"))
        {
            Debug.Log("trigger on remover");
            Destroy(gameObject);
        }
    }

    private void tempReverse()
    {
        
        currrentTime = 0;
        direction = -2;
        //enemySpeed = enemySpeed / -3;

    }

    public bool getDeath()
    {
        return death;
    }

    // Update is called once per frame
    void Update()
    {
        currrentTime += Time.deltaTime;
        enemyOrigPos = rb.transform.position;
        if (direction < 0) { 
            if (currrentTime > 14)
            {
                direction = 1;
            }
        }
        if (currrentTime > 19 && !death && enemySpeed < maximumSpeed) {
            enemySpeed *= speedGrowthFactor * direction;
            currrentTime = 0;
        }
        //Vector2 aim = player.position;
        enemyVec = ((Vector2)player.transform.position - enemyOrigPos).normalized;


        rb.velocity = new Vector2(enemyVec.x * enemySpeed,
                                enemyVec.y * enemySpeed);

        if (death && NIGHTCLUB ) {
            if (timeLeft <= Time.deltaTime)
            {

                targetColor = new Color(Random.value, Random.value, Random.value);
                timeLeft = 1.0f;

            }
            else
            {
                // transition in progress
                // calculate interpolated color
                targetColor = new Color(Random.value, Random.value, Random.value);
                this.gameObject.GetComponent<Renderer>().material.color =
                    Color.Lerp(this.gameObject.GetComponent<Renderer>().material.color,
                    targetColor, Time.deltaTime / timeLeft);

                // update the timer
                timeLeft -= Time.deltaTime;
            }
        }
    }
}
