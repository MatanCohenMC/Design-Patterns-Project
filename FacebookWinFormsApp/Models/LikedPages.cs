using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacebookApp.Dtos;

namespace FacebookApp.Models
{
    public class LikedPages
    {
        public ICollection<string> FetchUserPages()
        {
            List<string> likedPages = new List<string>();

            return likedPages;
        }

        public List<DataDto> FetchUserLikedPages()
        {
            throw new NotImplementedException();
        }
    }
}