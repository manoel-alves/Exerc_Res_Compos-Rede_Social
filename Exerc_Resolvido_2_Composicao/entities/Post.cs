using System;
using System.Collections.Generic;
using System.Text;

namespace Exerc_Resolvido_2_Composicao.entities
{
    class Post
    {

        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();


        public Post()
        {
        }

        public Post(DateTime moment, string title, string content, int likes)
        {
            Moment = moment;
            Title = title;
            Content = content;
            Likes = likes;
        }

        public void AddComment(string comment)
        {
            Comment newComment = new Comment(comment);
            Comments.Add(newComment);
        }

        public void RemoveComment(string comment)
        {
            Comment newComment = new Comment(comment);
            Comments.Remove(newComment);

        }

        public override string ToString()
        {
            StringBuilder resumo = new StringBuilder();
            resumo.AppendLine(Title);
            resumo.Append(Likes);
            resumo.Append(" Likes - ");
            resumo.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            resumo.AppendLine(Content);
            resumo.AppendLine("Comments:");
            foreach (Comment obj in Comments)
            {
                resumo.AppendLine(obj.Text);
            }
            return resumo.ToString();
        }

    }
}
