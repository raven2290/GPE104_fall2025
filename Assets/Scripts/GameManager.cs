using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Players")]
        public List<ControllerPlayer> players;

    [Header("Prefabs")]
        //prefabs for the game objects
    public GameObject playerPawnPrefab;
    public GameObject playerControllerPrefab;
    public GameObject meteorPrefab;
    public GameObject enemyStarShipPrefab;

    [Header ("Game Data")]
    // variables that relate to the game needs
    public float score;
    public float topScore;
    public int maxLives;
    public int currentLives;
    public List<Transform> meteorSpawnPoints;
    public List<Transform> enemyStarShipSpawnPoints;

    //[Header("Game Settings")]

    //settings for the game

    public void Awake()
    {
        if (instance !=null)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
        }
    }

    public Vector3 GetRandomSpawnPoints()
    {
        return (meteorSpawnPoints[Random.Range(0, meteorSpawnPoints.Count)].position);
        return (enemyStarShipSpawnPoints[Random.Range(0, enemyStarShipSpawnPoints.Count)].position);
    }

    public void SpawnMeteor()
    {
        
        GameObject newMeteor = Instantiate(meteorPrefab, GetRandomSpawnPoints(), Quaternion.identity) as GameObject;
        newMeteor.transform.Rotate(0.0f, 0.0f, Random.Range(0.0f, 360f));
        newMeteor.transform.position = newMeteor.transform.position + newMeteor.transform.up * Random.Range(-5.0f, 5.0f);
        Debug.Log("Spawned Meteor");
        
    }

    public void SpawnEnemyStarShip()
    {
        
        GameObject newEnemyStarShip = Instantiate(enemyStarShipPrefab, GetRandomSpawnPoints(), Quaternion.identity) as GameObject;
        newEnemyStarShip.transform.Rotate(0.0f, 0.0f, Random.Range(0.0f, 360f));
        Debug.Log("Spawned Enemy StarShip");
        
    }


    public void Start()
    {
        players = new List<ControllerPlayer>();

        //spawn the player controller
        SpawnPlayerController();

        //spawn the player pawn
        SpawnPlayer();

        //spawn some meteors
        for (int i = 0; i < 5; i++)
        {
            SpawnMeteor();
        }

        //spawn some enemy starships
        for (int i = 0; i < 3; i++)
        {
            SpawnEnemyStarShip();
        }
    }

    public void Update()
    {
    }

    public void SpawnPlayerController()
    {
        //instatiate a player controller
        GameObject newControllerObject = Instantiate(playerControllerPrefab, Vector3.zero, Quaternion.identity);
        ControllerPlayer newControllerPlayerComponent = newControllerObject.GetComponent<ControllerPlayer>();
        // store in player 0
        players.Add(newControllerPlayerComponent);
    }

    public void SpawnPlayer()
    {
        // if player currently has a pawn
        if (players[0].pawn != null)
        {
            Destroy(players[0].pawn.gameObject);
        }
        //instatiate a player pawn
        GameObject newPawnObject = Instantiate(playerPawnPrefab, Vector3.zero, Quaternion.identity) as GameObject;
        if (newPawnObject != null)
        {
            Pawn newPawn = newPawnObject.GetComponent<Pawn>();
            if (newPawn != null)
            {
                players[0].pawn = newPawn;
            }
        }
    }
}
