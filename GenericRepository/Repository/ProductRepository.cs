using GenericRepository.DMO;

namespace GenericRepository.Repository
{
    public class ProductRepository : GenericRepository<Product>
    {
        public ProductRepository(AdventureWorks2019Context context) : base(context) //BURDA ÖZEL REPOSİTORY YAZILABİLİR.
        {

            //yazılımdan dışa bağlanan herşey repository sayesinde gelir.
        }
    }
}
