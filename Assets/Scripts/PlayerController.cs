using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private Rigidbody rb;
    private int count;
    private float movementX;
    private float movementY;
    public float speed = 4;
    public TextMeshProUGUI  countText;
    public GameObject winTextObject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
        {
            count = 0;
            rb = GetComponent <Rigidbody>();
            SetCountText();
            winTextObject.SetActive(false);
        }
    void OnMove (InputValue movementValue)
        {
            Vector2 movementVector = movementValue.Get<Vector2>();
            movementX = movementVector.x;
            movementY = movementVector.y;
        }
    void SetCountText()
        {
            countText.text = "Count: " + count.ToString();
            if (count>= 20)
            {
                winTextObject.SetActive(true);
            }
        }
    private void FixedUpdate()
        {
            Vector3 movement = new Vector3 (movementX, 0.0f, movementY);
            rb.AddForce(movement * speed);
        }   
    void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("PickUp"))
            {
                other.gameObject.SetActive(false);
                count = count + 1;
                SetCountText();
            }
        }
}
