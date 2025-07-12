using UnityEngine;

namespace DesignPatterns.Factory
{
    public class ProductAB : MonoBehaviour, IProduct
    {
        [SerializeField]
        private string m_ProductName = "ProductAB";

        public string ProductName { get => m_ProductName; set => m_ProductName = value; }

        private ParticleSystem m_ParticleSystem;
        private AudioSource audioSource;

        public void Initialize()
        {
            gameObject.name = m_ProductName;
            m_ParticleSystem = GetComponentInChildren<ParticleSystem>();
            audioSource = GetComponent<AudioSource>();

            if (m_ParticleSystem == null)
                return;
            if (audioSource == null)
                return;
            m_ParticleSystem.Stop();
            m_ParticleSystem.Play();

            audioSource.Stop();
            audioSource.Play();
        }
    }
}
