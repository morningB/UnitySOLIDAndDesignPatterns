using UnityEngine;

namespace DesignPatterns.OCP
{
    public class CenterEffect : AreaOfEffect
    {
        [Header("Shape")]
        [Tooltip("The side length of the center")]
        [SerializeField] private float m_SideLength;
        public float point { get; private set; }

        public override float CalculateArea()
        {
             return point * 10f;
        }
    }

}
