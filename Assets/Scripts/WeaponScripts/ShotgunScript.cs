using UnityEngine;

public class ShotgunScript : MonoBehaviour
{
    public Camera cam;

    public float Ammo;

    public float ammoInMag;

    private float magSize = 10f;

    public float ShotDeviation;

    private float BulletsPerShot = 4;

    public bool canShoot;

    // Start is called before the first frame update
    void Update()
    {
      if (Input.GetButtonDown("Fire1"))
      {
        Shoot();
      }
    }

    public void Shoot()
    {
      RaycastHit hit;
      if (Physics.Raycast(cam.transform.position, cam.transform.forward, out hit))
      {
        Debug.Log(hit);
        if (hit.transform.gameObject.layer == LayerMask.NameToLayer("Enemy"))
        {
          hit.transform.gameObject.SendMessage("Die");
        }
      }
    }

    void Reload()
    {

    }
}
