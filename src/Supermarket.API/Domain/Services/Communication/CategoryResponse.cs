using Supermarket.API.Domain.Models;

namespace Supermarket.API.Domain.Services.Communication
{
    public class CategoryResponse : BaseResponse
    {
        public Category Category { get; private set; }

        private CategoryResponse(bool success, string message, Category category) : base(success, message)
        {
            Category = category;
        }

        /// <summary>
        /// Create a success response.
        /// <summary>
        /// <param name="category">Save category.</param>
        /// <returns>Response.</returns>
        public CategoryResponse(Category category) : this(true, string.Empty, category)
        { }

        /// <summary>
        /// Create an error response.
        /// <summary>
        /// <param name="message">Error message.</param>
        /// <returns>Response.</returns>
        public CategoryResponse(string message) : this(false, message, null)
        { }
    }

}