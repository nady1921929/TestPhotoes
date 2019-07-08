using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KharkivPhotoes.Entities
{
    public class Picture : BaseEntity
    {
        public Location Location { get; set; }
        public string Description { get; set; }
        public PictureType Type { get; set; }
        public DateTime DateOfLoading { get; set; }
    }
}
