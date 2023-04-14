using UnityEngine;

namespace Evstr.Player
{
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerFlap : MonoBehaviour
    {
        private Touch _touch;
        private Rigidbody2D _rigidbody2D;

        public static float ForceFlap = 7.0f;

        private void Start()
        {
            _rigidbody2D = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {

                _rigidbody2D.velocity = Vector2.up * ForceFlap;
            }
        }
    }
}