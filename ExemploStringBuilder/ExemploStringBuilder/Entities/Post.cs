using System;
using System.Collections.Generic;
using System.Text;

namespace ExemploStringBuilder.Entities
{
    class Post
    {
        public DateTime Moment { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public int Likes { get; private set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }
        
        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            // É utilizado para construir strings
            StringBuilder sb = new StringBuilder();
            // Adiciona uma string e quebra a linha no final
            sb.AppendLine(Title);
            // Adiciona uma string
            sb.Append(Likes);
            sb.Append(" Likes - ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine(Content);
            sb.AppendLine("Comments:");
            foreach (Comment comment in Comments)
            {
                sb.AppendLine(comment.Text);
            }

            return sb.ToString();
        }
    }
}
