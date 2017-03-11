using UnityEngine;

namespace Assets
{
    public class Invader : MonoBehaviour
    {
        public int Speed;
        public GameObject Explosion;

        private int _direction;

        public void Start()
        {
            _direction = Random.Range(0, 2) == 0 ? -1 : 1;
        }

        public void Update()
        {
            if (transform.position.x < -13)
            {
                _direction = 1;
            }

            if (transform.position.x > 13)
            {
                _direction = -1;
            }

            transform.position += new Vector3(_direction * Speed * Time.deltaTime, 0);
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            Explosion.transform.parent = null;
            Explosion.SetActive(true);
            Destroy(Explosion, 1);
        }
    }
}
