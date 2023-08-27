using System.Collections;
using System.Collections.Generic;
using UnityEngine;



/*
 +timed spawner on Apple and Poo
   +Spawn center follows the player
   +Spawn in circular
   +Spawn radius = camera width (adjustable by diff device)
*/
public class Spawner : MonoBehaviour
{
    public GameObject gameArea;
    public GameScreen gameScreen;
    public GameObject spawnPrefabPoo;
    public GameObject spawnPrefabApple;
    public GameObject coffeePrefab;
    public GameObject icecreamPrefab;
    public GameObject paperRollPrefab;

    public GameObject player;
    public Timer timer;

    private float currrentPooSpawnTime = 0;
    private float currrentFoodSpawnTime = 0;
    private float currrentPaperSpawnTime = 0;

    private float CircleRadius;
    private int PooNum;

    public float pooSpawnTime = 3;
    public float FoodSpawnTime = 2;
    public float PaperSpawnTime = 15;

    // Start is called before the first frame update
    void Start()
    {
        CircleRadius = Camera.main.orthographicSize *
                       Camera.main.aspect *
                       2;
        PooNum = 1;

        gameScreen.SetTotalPoo(PooNum);
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null) {
            transform.position = player.transform.position;
        }
        if (timer.GetTimerActive())
        {
            currrentPooSpawnTime += Time.deltaTime;
            currrentFoodSpawnTime += Time.deltaTime;
            currrentPaperSpawnTime += Time.deltaTime;
        }
        if (currrentPooSpawnTime > pooSpawnTime)
        {

            if (!player.GetComponent<Player>().getHighSpeed())
            {
                SpawnbyType(spawnPrefabPoo);
            }
            else
            {
                SpawnbyType(spawnPrefabPoo, CircleRadius + player.GetComponent<Player>().getSpeed() / 2);
            }
            currrentPooSpawnTime = 0;
        }
        if (currrentFoodSpawnTime > FoodSpawnTime)
        {
            SpawnbyType(spawnPrefabApple);
            SpawnbyType(coffeePrefab);
            SpawnbyType(icecreamPrefab);

            currrentFoodSpawnTime = 0;
        }

        if (currrentPaperSpawnTime > PaperSpawnTime)
        {
            Debug.Log("paper?");
            SpawnbyType(paperRollPrefab, CircleRadius * 2.5f);
            currrentPaperSpawnTime = 0;
        }

    }

    public void SpawnbyType(GameObject prefab) {
        //if poo update data
        if (prefab == spawnPrefabPoo) {
            PooNum++;
            gameScreen.SetTotalPoo(PooNum);
        }
        //if coffe or icecream, spawn farthur
        if (prefab == coffeePrefab)
        {
            Instantiate(prefab,
                        RandomCircle(transform.position, CircleRadius + 10),
                        Quaternion.identity);
        } else {
            Instantiate(prefab,
                        RandomCircle(transform.position, CircleRadius),
                        Quaternion.identity);
        }

    }
    public void SpawnbyType(GameObject prefab, float Radius)
    {
        //if poo update data
        if (prefab == spawnPrefabPoo)
        {
            PooNum++;
            gameScreen.SetTotalPoo(PooNum);
        }
        
        
        Instantiate(prefab,
                    RandomCircle(transform.position, Radius),
                    Quaternion.identity);
        

    }



    //https://answers.unity.com/questions/714835/best-way-to-spawn-prefabs-in-a-circle.html

    Vector3 RandomCircle (Vector3 center, float radius) {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
}
