using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        Vector3 move = new Vector3(x, 0, 0);

        transform.position += move * moveSpeed * Time.deltaTime;

        // âÊñ äOÇ…çsÇ©Ç»Ç¢ÇÊÇ§å≈íË
        float clampedX = Mathf.Clamp(transform.position.x, -7.5f, 7.5f);
        transform.position = new Vector3(clampedX, transform.position.y, 0);
    }
}
