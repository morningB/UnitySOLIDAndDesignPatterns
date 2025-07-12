using UnityEngine;

namespace DesignPatterns.Factory
{
    public class ConcreteFactoryAB : Factory
    {
        [SerializeField]
        private ProductAB m_ProductPrefab;

        public override IProduct GetProduct(Vector3 position)
        {
            GameObject instance = Instantiate(m_ProductPrefab.gameObject, position, Quaternion.identity);
            ProductAB newProduct = instance.GetComponent<ProductAB>();

            newProduct.Initialize();

            return newProduct;
        }
    }
}