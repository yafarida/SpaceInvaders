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
            int random = Random.Range(0, 2);

            if (random == 0)
            {
                _direction = -1;
            }
            else
            {
                _direction = 1;
            }
        }

        public void Update()
        {
            if (transform.position.x < -13)
            {
                _direction = 1;

                var position = transform.position;

                position.x = -13;
                position.y = position.y - 1;
                transform.position = position;
            }

            if (transform.position.x > 13)
            {
                _direction = -1;

                var position = transform.position;

                position.x = 13;
                position.y = position.y - 1;
                transform.position = position;
            }

            if (transform.position.y < -9)
            {
                Explode();
            }

            transform.position += new Vector3(_direction * Speed * Time.deltaTime, 0, 0);
        }

        public void OnTriggerEnter2D(Collider2D other)
        {
            Destroy(other.gameObject);
            Explode();
        }

        public void Explode()
        {
            Destroy(gameObject);
            Explosion.transform.parent = null;
            Explosion.SetActive(true);
            Destroy(Explosion, 1);
        }
    }
}
