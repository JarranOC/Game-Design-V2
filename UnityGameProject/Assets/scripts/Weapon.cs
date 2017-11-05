using UnityEngine;
using System.Collections;

public class Weapon : MonoBehaviour {

	public float fireRate = 0;
	public int Damage = 10;
	public LayerMask whatToHit;
	
	float timeToFire = 0;
	Transform firePoint;

    public Transform BulletTrailPrefab;
    public Transform MuzzleFlashPrefab;

    void Awake () {
		firePoint = transform.Find ("FirePoint");

		if (firePoint == null) {
		}
	}
	
	void Update () {

		if (fireRate == 0) {

			if (Input.GetButtonDown ("Fire1")) {

				Shoot();

			}

		}
		else {

			if (Input.GetButton ("Fire1") && Time.time > timeToFire) {

				timeToFire = Time.time + 1/fireRate;

				Shoot();

			}
		}
	}
	
	void Shoot () {
		Vector2 mousePosition = new Vector2 (Camera.main.ScreenToWorldPoint (Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);

        Vector2 firePointPosition = new Vector2 (firePoint.position.x, firePoint.position.y);

        RaycastHit2D hit = Physics2D.Raycast (firePointPosition, mousePosition-firePointPosition, 100, whatToHit);

        StartCoroutine("Effect");

        Debug.DrawLine (firePointPosition, (mousePosition-firePointPosition)*100, Color.cyan);

        if (hit.collider != null) {
			Debug.DrawLine (firePointPosition, hit.point, Color.red);

            enemy enemy = hit.collider.GetComponent<enemy>();

            if (enemy != null)
            {
                enemy.DamageEnemy(Damage);
                Debug.Log("We hit " + hit.collider.name + " and did " + Damage + " damage.");
            }

            //if (hit.collider.tag == "Enemy")
            //{
            //    Debug.Log("shooting enemy");
            //}
        }
      
        //if (hit.rigidbody)
        //{
        //    if (hit.rigidbody.tag == "Enemy")
        //    {
        //        Debug.Log("shooting enemy");
        //    }
        //}
        
    }


    IEnumerator Effect()
    {
        Instantiate(BulletTrailPrefab, firePoint.position, firePoint.rotation);

        Transform clone = Instantiate(MuzzleFlashPrefab, firePoint.position, firePoint.rotation) as Transform;
        clone.parent = firePoint;
        float size = Random.Range(0.6f, 0.9f);
        clone.localScale = new Vector3(size, size, size);
        yield return 0;
        Destroy(clone.gameObject, 0.02f);
    }
}
