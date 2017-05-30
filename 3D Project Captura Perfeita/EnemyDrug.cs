using UnityEngine;
using System.Collections;

public class EnemyDrug : MonoBehaviour
{

    public Transform SignalObject;
    public bool movimento;
    public int speed;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (movimento == true)
        {
            Move();
        }
    }

    void Move()
    {
        Quaternion movement;
        movement = Quaternion.LookRotation(SignalObject.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, movement, 6f * Time.deltaTime);
        transform.position = Vector3.MoveTowards(transform.position, SignalObject.position, speed * Time.deltaTime);


    }
}