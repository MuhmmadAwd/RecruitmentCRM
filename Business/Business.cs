using GlobalDev.entitiy;


namespace Business
{
    public class Business<TEntity> where TEntity : class
    {
        private readonly GDevContext Context;
        public Business(GDevContext context)
        {
            Context = context;
        }
        public IEnumerable<TEntity> GetAll()
        {
            return Context.Set<TEntity>().ToList();
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        public void Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
        }
    }
}
