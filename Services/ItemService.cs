using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ItemService
    {
        private IItemRepository _repository;

        public ItemService(IItemRepository repository)
        {
            _repository = new ItemRepository();
            _repository = repository;
        }

        public IItemRepository Get_repository()
        {
            return _repository;
        }

        public int Inserir(Item item, IItemRepository _repository)
        {
            return _repository.Inserir(item);
        }
    }
}
