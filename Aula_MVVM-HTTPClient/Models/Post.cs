using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_MVVM_HTTPClient.Models
{
   public class Post
    {
        private string userId;
        private string Id;
        private string title;
        private string body;

        public string UserId { get => userId; set => userId = value; }
        public string Id1 { get => Id; set => Id = value; }
        public string Title { get => title; set => title = value; }
        public string Body { get => body; set => body = value; }
    }
}
