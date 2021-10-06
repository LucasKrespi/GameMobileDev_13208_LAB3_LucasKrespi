using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    [Header("Enemy Movement")]
    public Bounds movementBunds;
    public Bounds startRange;

    [Header("Bullet")]
    public Transform bulletSpawner;
    public int frameDelay;

    private BulletManager bulletManager;

    private float startingPoint;
    private float ramdomSpeed;
    // Start is called before the first frame update
    void Start()
    {
        ramdomSpeed = Random.Range(movementBunds.min, movementBunds.max);
        startingPoint = Random.Range(startRange.min, startRange.max);
        bulletManager = GameObject.FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time, ramdomSpeed) + startingPoint, transform.position.y);
    }

    private void FixedUpdate()
    {
        if(Time.frameCount % frameDelay == 0)
        {
            bulletManager.GetBullet(bulletSpawner.position);
        }
    }
}
