using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private float speed;

    private GameObject player;

    private void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -1 * speed, 0);

        if (transform.position.y <= -4f) {
            Destroy(this.gameObject);
            FindObjectOfType<UIController>().Score++;
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = player.transform.position;

        Vector2 dir = p1 - p2;
        float d = dir.magnitude;
        
        // Ȥ��
        d = Vector2.Distance(p1, p2);

        float r1 = 0.5f; // ȭ���� �ݰ�
        float r2 = 1.0f; // �÷��̾� �ݰ�

        if (d < r1 + r2) {
            FindObjectOfType<UIController>().Hp--;
            Destroy(gameObject);
        }
    }
}
