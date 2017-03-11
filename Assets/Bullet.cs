using UnityEngine;

namespace Assets
{
    public class Bullet : MonoBehaviour
    {
        public int Speed;
        
        void Start()
        {
            Destroy(gameObject,2);
        }

        void Update()
        {
            transform.position += new Vector3(0, Speed*Time.deltaTime, 0);
        }
    }
}
