using UnityEngine;

public static class InputManager
{
    public static float vertical;
    public static float horizontal;

    public static void GetInput()
    {
        vertical = Input.GetAxis("Vertical");       // W y S ó ↑ y ↓
        horizontal = Input.GetAxis("Horizontal");   // A y D ó ← y →
    }
}
