using AutoMapper;
using AutoMapper.QueryableExtensions;
using HistoryPediaV2.Core.Exceptions;
using HistoryPediaV2.Data.DbContext;
using Microsoft.EntityFrameworkCore;

namespace HistoryPediaV2.Core.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext Context;
        protected readonly IMapper _mapper;
        
        public GenericRepository(ApplicationDbContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        public async Task<TResult> AddAsync<TSource, TResult>(TSource source)
        {
            var entity = _mapper.Map<T>(source);

            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();

            return _mapper.Map<TResult>(entity);
        }

        public async Task DeleteAsync(long id)
        {
            var entity = await GetAsync(id);
            if(entity is null)
            {
                throw new NotFoundException(typeof(T).Name, id);
            }

            Context.Set<T>().Remove(entity);
            await Context.SaveChangesAsync();
        }

        public async Task<List<TResult>> GetAllAsync<TResult>()
        {
            return await Context.Set<T>()
                .ProjectTo<TResult>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<TResult> GetAsync<TResult>(long? id)
        {
            var result = await Context.Set<T>().FindAsync(id);
            if (result is null)
            {
                throw new NotFoundException(typeof(T).Name, id.HasValue ? id : "No key provided");
            }

            return _mapper.Map<TResult>(result);
        }

        public async Task UpdateAsync<TSource>(long id, TSource source)
        {
            var entity = await GetAsync(id);
            if (entity is null)
            {
                throw new NotFoundException(typeof(T).Name, id);
            }

            _mapper.Map(entity, source);
            Context.Update(entity);
            await Context.SaveChangesAsync();
        }

        protected async Task<T> AddAsync(T entity)
        {
            await Context.AddAsync(entity);
            await Context.SaveChangesAsync();
            return entity;
        }

        protected async Task<bool> Exists(long id)
        {
            var entity = await GetAsync(id);
            return entity is not null;
        }

        protected async Task<T?> GetAsync(long? id)
        {
            if(id is null)
            {
                return null;
            }

            return await Context.Set<T>().FindAsync(id);
        }

        protected async Task<List<T>> GetAllAsync()
        {
            return await Context.Set<T>().ToListAsync();
        }

        protected async Task UpdateAsync(T entity)
        {
            Context.Update(entity);
            await Context.SaveChangesAsync();
        }
    }
}
