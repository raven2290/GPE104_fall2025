using UnityEngine;


public class SizingAndMoving : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    



    private void Awake()
    {
        //load our sprite renderer into that variable
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set initial location
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("move up"); //this will print to the console  showing no errors
            spriteRenderer.transform.position += new Vector3(0, 1, 0);  //move object up by 1 unit
        }
       
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("move down"); //this will print to the console  showing no errors
            spriteRenderer.transform.position += new Vector3(0, -1, 0); //move object down by 1 unit
        }
        
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("move left"); //this will print to the console  showing no errors
            spriteRenderer.transform.position += new Vector3(-1, 0, 0); //move object left by 1 unit
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("move right"); //this will print to the console  showing no errors
            spriteRenderer.transform.position += new Vector3(1, 0, 0); //move object right by 1 unit
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("warp 5 spaces up"); //this will print to the console  showing no errors
            spriteRenderer.transform.position += new Vector3(0, 5, 0);  //move object up by 5 units
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("warp 5 spaces down");//this will print to the console  showing no errors
            spriteRenderer.transform.position += new Vector3(0, -5, 0);  //move object down by 5 units
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("warp 5 spaces left"); //this will print to the console  showing no errors
            spriteRenderer.transform.position += new Vector3(-5, 0, 0);  //move object left by 5 units
        }

        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("warp 5 spaces right"); //this will print to the console  showing no errors
            spriteRenderer.transform.position += new Vector3(5, 0, 0);  //move object right by 5 units
        }
    }
}