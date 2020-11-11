using UnityEngine;

public class ShotgunScript : MonoBehaviour
{
    public Camera cam;

    private Transform tf;

    public GameObject bulletPrefab;

    private Vector3 shootPoint = new Vector3(0, 0, (float)0.04);

    public float Ammo = 100;

    public float ammoInMag = 10f;

    private float magSize = 10f;

    private float BulletsPerShot = 4;

    public bool canShoot;

    void Start()
    {
      tf = GetComponent<Transform>();
    }
    // Start is called before the first frame update
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
      {
        if (ammoInMag >= BulletsPerShot)
        {
          for (int i = 0; i < BulletsPerShot; i++)
          {
            Shoot();
          }
        }
        else
        {
          for (int i = 0; i < ammoInMag; i++)
          {
            Shoot();
          }
        }
      }
      if (Input.GetKeyDown(KeyCode.R))
      {
        Debug.Log("reload");
      }
    }

    void Shoot()
    {
      Vector3 deviationVec = new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5));
      Quaternion deviationQuat = Quaternion.Euler(deviationVec);
      Instantiate(bulletPrefab, tf.position + shootPoint, tf.rotation * deviationQuat);
      Debug.Log("Pew!!");
      ammoInMag -= 1;
    }

    void Reload()
    {

    }
}
