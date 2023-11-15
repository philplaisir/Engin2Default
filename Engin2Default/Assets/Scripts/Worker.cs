using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    public static List<Collectible> s_KnownCollectibles { get; set; } = new List<Collectible>();
    public static List<Camp> s_Camps { get; set; } = new List<Camp>();
    [SerializeField]
    private float m_radius = 5.0f;
    [SerializeField]
    private Transform m_radiusDebugTransform;


    void OnValidate()
    {
       m_radiusDebugTransform.localScale = new Vector3(m_radius, m_radius, m_radius);
    }

    public static void TryAddCollectible(Collectible collectible)
    {


    }
   
}






