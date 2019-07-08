using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KharkivPhotoes.Interfaces;
using KharkivPhotoes.Entities;
using KharkivPhotoes.DB;

namespace KharkivPhotoes.Implementation
{
    public class KharkivPhotoesRepository : IRepository<Picture>
    {
        private readonly PicturesContext context;

        public KharkivPhotoesRepository(PicturesContext context)
        {
            this.context = context;
        }

        public int Create(Picture item)
        {
            this.context.Pictures.Add(item);
            return item.Id;
        }

        public void Delete(int id)
        {
            this.context.Pictures.Remove(this.Get(id));
        }

        public Picture Get(int id)
        {
            return this.context.Pictures.FirstOrDefault(i => i.Id.Equals(id));
        }

        public IEnumerable<Picture> GetAll()
        {
            return this.context.Pictures.ToList();
        }

        public void Save()
        {
            this.context.SaveChanges();
        }

        public void Update(Picture item)
        {
            this.context.Pictures.Update(item);
        }
    }
}
