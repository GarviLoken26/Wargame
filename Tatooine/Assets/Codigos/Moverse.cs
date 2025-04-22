using UnityEngine;

public class Moverse : MonoBehaviour
{
    public Animator anim;
    public float speed;
    private Rigidbody m_Rb;

    void Start()
    {

    }


    void Update()
    {
        float tempSpeed = 0;
        tempSpeed += speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.I))
        {
            this.transform.Translate(0, 0, tempSpeed);
            anim.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.I))
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.K))
        {
            this.transform.Translate(0, 0, -tempSpeed);
            anim.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.K))
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.J))
        {
            this.transform.Translate(tempSpeed, 0, 0);
            anim.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.J))
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetKey(KeyCode.L))
        {
            this.transform.Translate(-tempSpeed, 0, 0);
            anim.SetBool("Walk", true);
        }
        else if (Input.GetKeyUp(KeyCode.L))
        {
            anim.SetBool("Walk", false);
        }
    }
}
