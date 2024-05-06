using BlazorServerApp.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp.Services
{
    public class TodoService
    {
        private readonly TodoDbContext _context;

        public TodoService(TodoDbContext context)
        {
            _context = context;
        }

        public async Task AddTodoAsync(TodoItem todo)
        {
            _context.Todos.Add(todo);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TodoItem>> GetTodosAsync()
        {
            return await _context.Todos.ToListAsync();
        }
        public async Task DeleteTodoAsync(TodoItem todo)
        {
            _context.Todos.Remove(todo);
            await _context.SaveChangesAsync();
        }
    }
}
