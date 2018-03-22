using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float Speed = 6f;

    Vector3 movement;
    //Animator anim;
    Rigidbody PlayerRigidbody;
    int FloorMask;
    float camRayLength = 100f;

    void Awake()
    {
        //tell raycast we only want to hit floor
        FloorMask = LayerMask.GetMask("Floor");
        //anim = GetComponent<Animator>();
        PlayerRigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
        Turning();
        //Animating(h, v);
    }

    void Move (float h, float v)
    {
        //give vector3 values
        movement.Set(h, 0f, v);
        movement = movement.normalized * Speed * Time.deltaTime;

        PlayerRigidbody.MovePosition(transform.position + movement);
    }

    void Turning()
    {
        Ray camRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit floorHit;

        if(Physics.Raycast(camRay, out floorHit, camRayLength, FloorMask))
        {
            Vector3 PlayerToMouse = floorHit.point - transform.position;
            PlayerToMouse.y = 0f;

            Quaternion NewRotation = Quaternion.LookRotation(PlayerToMouse);
            PlayerRigidbody.MoveRotation(NewRotation);
        }

        /*
        void Animating(float h, float v)
        {
            //h is true if not equal to 0, v is true if not equal to 0
            bool walking = h != 0f || v != 0f;
            anim.SetBool("IsWalking", walking);
        }
        */
    }

}
