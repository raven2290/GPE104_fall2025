using UnityEngine;

public class EnemyStarShipPawn : MonoBehaviour
{
    private Transform enemyPawn;
    private Transform playerPawn;

    // ai checks
    public bool chasing = false;
    public bool evading = false;

    // AI settings
    public float rotationSpeed;
    public float maxDist;
    public float minDist;
    public float fireDist;

    //AI speeds
    public float moveSpeed;

    void start()
    {
        enemyPawn = this.gameObject.GetComponent<Transform>();
        playerPawn = GameManager.instance.players[0].pawn.GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        if (playerPawn != null)
        {
            float dist = Vector3.Distance(enemyPawn.position, playerPawn.position);
            // check if we should be chasing or evading
            if (dist < maxDist && dist > minDist)
            {
                chasing = true;
                evading = false;
            }
            else if (dist < minDist)
            {
                chasing = false;
                evading = true;
            }
            else
            {
                chasing = false;
                evading = false;
            }
            //move towards the player
            Vector3 direction = playerPawn.position - enemyPawn.position;
            // rotate towards the player
            Quaternion targetRotation = Quaternion.LookRotation(direction);
            enemyPawn.rotation = Quaternion.Slerp(enemyPawn.rotation, targetRotation, rotationSpeed * Time.deltaTime);
            // move towards or away from the player
            if (chasing)
            {
                enemyPawn.position += enemyPawn.forward * moveSpeed * Time.deltaTime;
            }
            else if (evading)
            {
                enemyPawn.position -= enemyPawn.forward * moveSpeed * Time.deltaTime;
            }
            // fire at the player if within range
            if (dist < fireDist)
            {
                Shooter shooter = GetComponent<Shooter>();
                if (shooter != null)
                {
                    shooter.Shoot();
                }
            }
        }
    }
}
