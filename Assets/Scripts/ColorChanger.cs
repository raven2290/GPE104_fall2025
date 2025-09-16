using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    //TODO: CREATE A VARIABLE TO HOLD OUR SPRITE RENDERER COMPONENT
    private SpriteRenderer spriteRenderer;
    public Color spriteColor = Color.green;


    //AWAKE RUNS WHEN AN OBJECT IS CREATED
    private void Awake()
    {
        //TODO: LOAD OUR SPRITE RENDERER INTO THAT VARIABLE
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        if (spriteRenderer == null)
        {
            Debug.LogError("error object");
        }
        else
        {
            //CHANGE THE SPRITE COLOR TO GREEN
            spriteRenderer.color = spriteColor;
        }
    }

    // Update is called once per frame
    private void Update()
    {
       
    }
}
