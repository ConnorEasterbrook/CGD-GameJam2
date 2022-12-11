using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

public class PersonCollision : MonoBehaviour
{
    Rigidbody rb;
    Collider col;
    Animator anim;
    public bool flyAway = false;
    public GameObject car;
    private bool timeToSpin = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        col = GetComponent<Collider>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (timeToSpin)
        {
            transform.Rotate(10, 10, 10);
        }
    }

    async void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            rb.isKinematic = false;
            rb.useGravity = true;

            if (!flyAway)
            {
                rb.AddForce(transform.up / 250, ForceMode.Impulse);
            }
            else
            {
                rb.AddForce(transform.up / 200, ForceMode.Impulse);
                rb.AddForce(car.transform.forward / 100, ForceMode.Impulse);
            }

            col.isTrigger = false;
            Destroy(anim);
            timeToSpin = true;

            await Task.Delay(1000);
            transform.rotation = Quaternion.Euler(90, 0, 90);

            await Task.Delay(2000);
            col.isTrigger = true;
            Destroy(rb);
            timeToSpin = false;

            await Task.Delay(10000);
            Destroy(gameObject);
        }
    }
}
