using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [Header("Enemy Movement")]
    public Bounds movementBunds;
    public Bounds startRange;


    private float startingPoint;
    private float ramdomSpeed;
    // Start is called before the first frame update
    void Start()
    {
        ramdomSpeed = Random.Range(movementBunds.min, movementBunds.max);
        startingPoint = Random.Range(startRange.min, startRange.max);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time, ramdomSpeed) + startingPoint, transform.position.y);
    }
}
