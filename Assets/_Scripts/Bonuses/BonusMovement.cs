using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Bonuses
{
    public class BonusMovement : MonoBehaviour
    {
        private float _speed = 2.0f;

        private void Update()
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
            if (transform.position.x < -12.0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
