using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public float kecepatan = 5f;
    private Vector2 arahGerak;
    
    //Variabel Skor
    public int skor = 0;

    void OnMove(InputValue value)
    {
        arahGerak = value.Get<Vector2>();
    }

    void Update()
    {
        Vector3 arah = new Vector3(arahGerak.x, arahGerak.y, 0);
        transform.position += arah * kecepatan * Time.deltaTime;
    }

    //Deteksi Koin dan Skor
    void OnTriggerEnter2D(Collider2D other)
    {
        //Cek apakah objek yang ditabrak memiliki tag "Coin"
        if (other.CompareTag("Coin"))
        {
            //Hancurkan koin yang disentuh
            Destroy(other.gameObject);

            //Tambah skor sebanyak 1
            skor++;

            //Tampilkan skor ke Console
            Debug.Log("Skor Kamu Saat Ini: " + skor);
            
            //Logika Tugas 5 akan memanggil GameManager di sini nanti
            GameManager gm = FindObjectOfType<GameManager>();
            if (gm != null)
            {
                gm.AmbilKoin();
            }
        }
    }
}