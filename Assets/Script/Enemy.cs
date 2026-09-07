using UnityEngine;

public class Enemy : MonoBehaviour, IDamageable
{
    [SerializeField] private int hp = 100;
    public float ms = 2f;
    protected Transform player;

    protected virtual void Start()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if (playerObj != null)
        {
            player = playerObj.transform;
        }
    }

    void Update()
    {
        Kejar();
    }

    public void Kejar()
    {
        if (player == null) return;

        transform.position = Vector2.MoveTowards(
            transform.position,
            player.position,
            ms * Time.deltaTime
        );
    }

    public virtual void Serang()
    {
        Debug.Log("Enemy menyerang!");
    }

    // DIUBAH DI SINI: Ganti nama fungsi & parameter biar cocok sama IDamageable
    public virtual void TakeDamage(int damage)
    {
        hp -= damage;
        Debug.Log($"{gameObject.name} kena damage {damage}, HP sisa: {hp}");

        if (hp <= 0)
        {
            Mati();
        }
    }

    private void Mati()
    {
        Debug.Log($"{gameObject.name} mati!");
        Destroy(gameObject);
    }
}