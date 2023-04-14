using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr
{
    public class BonusSpawner : MonoBehaviour
    {
        private float _xPosition = 12.0f;
        private float _yPosition;
        private float _yBoards = 4.0f;


        private void Start()
        {
            StartCoroutine(SpawnObstacle());
        }

        private IEnumerator SpawnObstacle()
        {
            while (true)
            {
                yield return new WaitForSeconds(1.6f);
                GameObject bonus = ObjectPool.SharedInstance.GetPooledObjectStarBonus();
                _yPosition = Random.Range(-_yBoards, _yBoards);
                if (bonus != null)
                {
                    bonus.transform.position = new Vector2(_xPosition, _yPosition);
                    bonus.SetActive(true);
                }
            }
        }
    }
}
