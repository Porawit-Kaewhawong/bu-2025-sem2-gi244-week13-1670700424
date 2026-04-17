using UnityEngine;

public class GameSettings
{
    public static bool enableShadow;
    public static float globalGravity;
    public static int difficulty;

    private static string apiKey;

    public static string GetApiKey()
    {
        return apiKey;
    }
}