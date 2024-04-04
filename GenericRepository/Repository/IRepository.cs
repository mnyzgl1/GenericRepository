namespace GenericRepository.Repository
{
	public interface IRepository<TEntity>
	{
		// Generic repository'de aşağıdaki metotlar olmalıdır.
		//CRUD CREATE READ UPDATE DELETE 
		IQueryable<TEntity> GetAll();
		TEntity GetById(int id);
		void Create(TEntity entity);

		void Update(int id, TEntity entity);

		void Delete(int id);
	}
}
