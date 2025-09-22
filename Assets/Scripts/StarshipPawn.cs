using UnityEngine;

public class StarshipPawn : Pawn
{
    public float moveSpeed; //the speed of pawn
    public float rotationSpeed; //speed of rotation

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    protected override void Start()
    {
        // TODO do anything a spaceship does on start

        // this runs instead of parent for the override
        // we can add base.Start() to run both
        base.Start();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override void Move(Vector3 moveVector)
    {
        //Transform myTransform = this.gameObject.GetComponent<Transform>(); **long version
        transform.position = transform.position + (moveVector * moveSpeed) * Time.deltaTime;

    }

    public override void Rotate(float angle)
    {
        transform.Rotate(new Vector3(0, 0, angle * rotationSpeed) * Time.deltaTime);
    }
}
