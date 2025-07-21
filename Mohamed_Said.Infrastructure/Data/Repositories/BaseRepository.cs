using Microsoft.EntityFrameworkCore;
using Mohamed_Said.Core.Entities;
using Mohamed_Said.Core.Interfaces.Repositories;
using Mohamed_Said.Infrastructure.Data.DbContexts;
using Mohamed_Said.Shared.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Mohamed_Said.Infrastructure.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id); // go to database to find entity and make it async to not block the thread
        }

        public async Task<IEnumerable<T>> GetAllAsync() // List Implements IEnumerable so I can assign List to IEnumerable 
        {
            return await _context.Set<T>().ToListAsync();  // return new List<T>();
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, object>> orderByCriteria, string orderByDirection = OrderBy.Ascending, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>(); // Get all entities from the database

            if (includes is not null)
                foreach (string include in includes)
                {
                    query = query.Include(include); // Include related entities if any are specified
                }

            if (orderByDirection == OrderBy.Ascending)
            {
                query = query.OrderBy(orderByCriteria); // Order the results in ascending order
            }
            else if (orderByDirection == OrderBy.Descending)
            {
                query = query.OrderByDescending(orderByCriteria); // Order the results in descending order
            }

            return await query.ToListAsync(); // Return the list of entities that match the criteria
        }

        public async Task<T?> FindAsync(Expression<Func<T, bool>> criteria, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>(); // Get the entity by Id from the database
            if (includes is not null)
                foreach (string include in includes)
                {
                    query = query.Include(include); // Include related entities if any are specified
                }

            return await query.FirstOrDefaultAsync(criteria); // Return the entity that matches the Id or null if not found
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>().Where(criteria); // Get all entities from the database that match the criteria
            if (includes is not null)
                foreach (string include in includes)
                {
                    query = query.Include(include); // Include related entities if any are specified
                }

            return await query.ToListAsync(); // Return the list of entities that match the criteria
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>().Where(criteria).Skip(skip).Take(take); // Get all entities from the database that match the criteria
            if (includes is not null)
                foreach (string include in includes)
                {
                    query = query.Include(include); // Include related entities if any are specified
                }

            return await query.ToListAsync(); // Return the list of entities that match the criteria
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria, int skip, int take, Expression<Func<T, object>> orderByCriteria, string orderByDirection = OrderBy.Ascending, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>().Where(criteria).Skip(skip).Take(take); // Get all entities from the database that match the criteria

            if (includes is not null)
                foreach (string include in includes)
                {
                    query = query.Include(include); // Include related entities if any are specified
                }

            if (orderByDirection == OrderBy.Ascending)
            {
                query = query.OrderBy(orderByCriteria); // Order the results in ascending order
            }
            else if (orderByDirection == OrderBy.Descending)
            {
                query = query.OrderByDescending(orderByCriteria); // Order the results in descending order
            }

            return await query.ToListAsync(); // Return the list of entities that match the criteria
        }

        public async Task<IEnumerable<T>> FindAllAsync(Expression<Func<T, bool>> criteria,Expression<Func<T, object>> orderByCriteria, string orderByDirection = OrderBy.Ascending, string[]? includes = null)
        {
            IQueryable<T> query = _context.Set<T>().Where(criteria); // Get all entities from the database that match the criteria

            if (includes is not null)
                foreach (string include in includes)
                {
                    query = query.Include(include); // Include related entities if any are specified
                }

            if (orderByDirection == OrderBy.Ascending)
            {
                query = query.OrderBy(orderByCriteria); // Order the results in ascending order
            }
            else if (orderByDirection == OrderBy.Descending)
            {
                query = query.OrderByDescending(orderByCriteria); // Order the results in descending order
            }

            return await query.ToListAsync(); // Return the list of entities that match the criteria
        }


        public T? Add(T entity)
        {
            if(entity is null)
                return null;

            _context.Set<T>().Add(entity); // to change the entity state to Added and not blocking the thread
            return entity; // Return the added entity
        }

        public T? Update(T entity)
        {
            if (entity is null)
                return null;

            _context.Set<T>().Update(entity); // to change the entity state to Modified and not blocking the thread
            return entity; // return the updated entity
        }

        public T? Delete(T entity)
        {
            if (entity is null)
                return null;

            _context.Set<T>().Remove(entity); // to change the entity state to Deleted and not blocking the thread
            return entity; // return the deleted entity
        }

        public async Task<int> CountAsync()
        {
            return await _context.Set<T>().CountAsync(); // Count all entities in the table in database
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> criteria)
        {
            return await _context.Set<T>().CountAsync(criteria); // Count all entities in the table that match the criteria in database
        }
    }
}
