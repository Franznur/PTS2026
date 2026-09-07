using UnityEngine;

// Inheritance: Zombie adalah turunan dari Enemy
public class Zombie : Enemy
{
    // Polymorphism: Mengubah/override perilaku fungsi Serang dari Enemy
    public override void Serang()
    {
        Debug.Log("Zombie menggigit player!");
    }

    // Polymorphism: Mengubah/override perilaku TakeDamage dari Enemy
    public override void TakeDamage(int damage)
    {
        base.TakeDamage(damage); // tetep ngurangin HP dari parent
        Debug.Log("Zombie mengerang kesakitan!");
    }
}