using BlogLab.Models.BlogComment;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlogLab.AccountRepository
{
    public interface IBlogCommentRepository
    {
        public Task<BlogComment> UpsertAsync(BlogCommentCreate blogCommentCreate, int applicationUserId);

        public Task<List<BlogComment>> GetAllAsync(int blogCommentId);
        public Task<BlogComment> GetAsync(int blogCommentId);
        public Task<int> DeleteAsync(int blogCommentId);
    }
}
