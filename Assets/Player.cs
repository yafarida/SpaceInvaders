using UnityEngine;

namespace Assets
{
    public class Player : MonoBehaviour
    {
        public int Speed;
        public GameObject BulletPrefab;

        void Start ()
        {
		
        }
	
        void Update ()
        {
            if (Input.GetKey(KeyCode.LeftArrow) && transform.position.x > -13)
            {
                transform.position -= new Vector3(Speed*Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.RightArrow) && transform.position.x < 13)
            {
                transform.position += new Vector3(Speed*Time.deltaTime, 0, 0);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(BulletPrefab, transform.position, Quaternion.identity);
            }
        }
    }
}
