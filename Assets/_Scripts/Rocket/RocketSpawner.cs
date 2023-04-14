using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace Evstr.Rocket
{
    public class RocketSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _player;

        public void SpawnRocket()
        {
            GameObject rocket = ObjectPool.SharedInstance.GetPooledObjectRocket();

            if (rocket != null)
            {
                rocket.transform.position = new Vector2(-2.5f, _player.transform.position.y - 0.3f);
                rocket.SetActive(true);
            }
        }
    }
}
