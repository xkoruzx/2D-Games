using UnityEngine;

public class CameraController : MonoBehaviour
{
   [SerializeField] private float speed;

   private float currentPosX;
   private Vector3 velocity = Vector3.zero;

   [SerializeField] private Transform player;
   [SerializeField] private float aheadDistance;
   [SerializeField] private float cameraSpeed;

    private float lookAhead;
    // Update is called once per frame
    private void Update()
    {
        //Room Camera
        transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX - 1, transform.position.y, transform.position.z), ref velocity, speed);

        //follow player (For Nanon)
        // transform.position = new Vector3(player.position.x + lookAhead, transform.position.y, transform.position.z);
        // lookAhead = Mathf.Lerp(lookAhead, (aheadDistance * player.localScale.x), Time.deltaTime * cameraSpeed);


    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPosX = _newRoom.position.x  - 1;
    }
}
