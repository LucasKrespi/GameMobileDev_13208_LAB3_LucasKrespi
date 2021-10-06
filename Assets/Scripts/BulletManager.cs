using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class BulletManager : MonoBehaviour
{
    public Queue<GameObject> bulletPool;
    public int bulletNumber;
    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        bulletPool = new Queue<GameObject>();
       // BuildBulletPoll();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void BuildBulletPoll()
    {
        for(int i = 0; i < bulletNumber; i++)
        {
            AddBullet();
        }
    }

    private void AddBullet()
    {
        var temp_Bullet = Instantiate(bulletPrefab);
        temp_Bullet.SetActive(false);
        temp_Bullet.transform.parent = transform;
        bulletPool.Enqueue(temp_Bullet);
    }

    public GameObject GetBullet(Vector2 position)
    {
        if(bulletPool.Count < 1)
        {
            AddBullet();
            bulletNumber++;
        }
        var temp_bullet = bulletPool.Dequeue();
        temp_bullet.SetActive(true);
        temp_bullet.transform.position = position;
        return temp_bullet;
    }

    public void ReturnBullet(GameObject return_Bullet)
    {
        return_Bullet.SetActive(false);
        bulletPool.Enqueue(return_Bullet);
    }
}
