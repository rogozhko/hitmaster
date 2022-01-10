using UnityEngine;

public class RayCreator : MonoBehaviour
{
    private InputManager inputManager;
    private Camera cameraMain;

    public GameObject player;
    public GameObject bullet;


    private void Awake()
    {
        inputManager = InputManager.Instance;
        cameraMain = Camera.main;
    }


    private void OnEnable()
    {
        inputManager.OnStartTouch += CreateRay;
    }

    private void OnDisable()
    {
        inputManager.OnStartTouch -= CreateRay;
    }


    private void CreateRay(Vector2 screenPosition, float time)
    {
        Vector3 screenCoordinates = new Vector3(screenPosition.x, screenPosition.y, 0);

        Ray ray = cameraMain.ScreenPointToRay(screenCoordinates);

        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, 1000))
        {
            Vector3 hitPosition = hit.transform.position;
            Debug.Log(hit.collider.gameObject.name);
            Debug.Log(hit.collider.gameObject.transform.position);
            targetPosition = hit.collider.gameObject.transform.position;
            Shoot();
        }

    }


    Vector3 targetPosition;

    private void Shoot()
    {
        GameObject newBullet = Instantiate(bullet, player.transform.position, player.transform.rotation);
        newBullet.GetComponent<Rigidbody>().AddForce(targetPosition * 2, ForceMode.Impulse);
    }
}
