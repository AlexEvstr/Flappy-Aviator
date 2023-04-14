using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr
{
    public class ObjectPool : MonoBehaviour
    {
        public static ObjectPool SharedInstance;
        public List<GameObject> objectToPool;

        public List<GameObject> pooledObstacles;
        public List<GameObject> pooledStarsBonus;
        public List<GameObject> pooledEnemies;

        public int amountToPoolObstacle;
        public int amountToPoolStarBonus;
        public int amountToPoolEnemy;

        private void Awake()
        {
            SharedInstance = this;
        }

        private void Start()
        {
            PoolObstacles();
            PoolStars();
        }

        public GameObject GetPooledObjectObstacle()
        {
            for (int i = 0; i < amountToPoolObstacle; i++)
            {
                if (!pooledObstacles[i].activeInHierarchy)
                {
                    return pooledObstacles[i];
                }
            }
            return null;
        }

        private void PoolObstacles()
        {
            pooledObstacles = new List<GameObject>();
            GameObject obstacle;
            for (int i = 0; i < amountToPoolObstacle; i++)
            {
                obstacle = Instantiate(objectToPool[0]);
                obstacle.SetActive(false);
                pooledObstacles.Add(obstacle);
            }
        }

        public GameObject GetPooledObjectStarBonus()
        {
            for (int i = 0; i < amountToPoolStarBonus; i++)
            {
                if (!pooledStarsBonus[i].activeInHierarchy)
                {
                    return pooledStarsBonus[i];
                }
            }
            return null;
        }

        private void PoolStars()
        {
            pooledStarsBonus = new List<GameObject>();
            GameObject obstacle;
            for (int i = 0; i < amountToPoolStarBonus; i++)
            {
                obstacle = Instantiate(objectToPool[1]);
                obstacle.SetActive(false);
                pooledStarsBonus.Add(obstacle);
            }
        }
    }
}
