using UnityEngine;

public class ControllerPlayer : Controller
{
    public Pawn pawn; //the pawn being controlled


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //#.movement()
        { //basic movements
            if
                (
                    Input.GetKey(KeyCode.W)
                    || Input.GetKey(KeyCode.UpArrow)

                )
            {
                //Transform tf = this.gameObject.GetComponent<Transform>(); **long version

                pawn.Move(pawn.transform.up);
            }
            else if
                (
                    Input.GetKey(KeyCode.S)
                    || Input.GetKey(KeyCode.DownArrow)
                )
            {
                pawn.Move(-pawn.transform.up);
            }


            if
                (
                    Input.GetKey(KeyCode.A)
                    || Input.GetKey(KeyCode.LeftArrow)
                   

                )
            {
                pawn.Rotate(1.0f);
                Debug.Log("rotate left");
            }

            else if
                (
                    Input.GetKey(KeyCode.D)
                    || Input.GetKey(KeyCode.RightArrow)

                )
            {
                pawn.Rotate(-1.0f);
                Debug.Log("rotate right");
            }
        }
        //#.advanced movement
        if
            (
                Input.GetKey(KeyCode.LeftShift)
                && Input.GetKey(KeyCode.W)
                || Input.GetKey(KeyCode.UpArrow)
            )
        {
            pawn.Move(2 * (pawn.transform.up));
        }

        else if
            (
                Input.GetKey(KeyCode.LeftShift)
                && Input.GetKey(KeyCode.S)
                || Input.GetKey(KeyCode.DownArrow)
            )
        {
            pawn.Move(2 * (-pawn.transform.up));
        }
        
            //#.straffing() TODO: CREATE STRAFFING EFFECT ???
        { //move left or right without changing facing direction
         /*   if
                (
                    Input.GetKey(KeyCode.LeftShift)
                    && Input.GetKey(KeyCode.A)
                    || Input.GetKey(KeyCode.LeftArrow)
                )
            {
                pawn.Move(-pawn.transform.right);
                pawn.Move(pawn.transform.up);
                Debug.Log("strafe left");
            }
            
            else if
                (
                    Input.GetKey(KeyCode.D)
                    || Input.GetKey(KeyCode.RightArrow)
                    && Input.GetKey(KeyCode.LeftShift)
                )
            {
                pawn.Move(pawn.transform.right);
                pawn.Move(pawn.transform.up);
                Debug.Log("strafe right");
            }*/
        }
    
    }
}
