using UnityEngine;

[CreateAssetMenu(menuName = "TypeSearchTest/Human")]
[System.Serializable]
public class Human : ScriptableObject
{
    public string firstName;
    public bool isMale;
}