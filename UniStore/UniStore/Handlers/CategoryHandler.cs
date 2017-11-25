using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UniStore.Stores;

namespace UniStore.Handlers
{
    public interface ICategoryHandler
    {

    }

    public class CategoryHandler : ICategoryHandler
    {
        private readonly ICategoryStore categoryStore;

        public CategoryHandler(ICategoryStore categoryStore)
        {
            this.categoryStore = categoryStore;
        }


    }
}