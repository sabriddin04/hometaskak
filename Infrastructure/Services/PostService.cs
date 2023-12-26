using Domain.Models;

namespace Infrastructure.Services;

public class PostService
{



List<Post> Posts=new List<Post>();

public List<Post> GetPosts(){

   return Posts;

}

public void AddPost(Post post){

    Posts.Add(post);
}

public void UpdatePost(Post post){

foreach ( var p  in Posts)
{
    if(post.Id==p.Id){
       p.Title=post.Title;
       p.Description=post.Description;
       p.VoteAmount=post.VoteAmount;
       p.CreateAt=post.CreateAt;
    }
    
}

}
public void Delete(int id){

 for (int i = 0; i < Posts.Count; i++)
 {
    if(id==Posts[i].Id){
Posts.Remove(Posts[i]);

    }
    
 }

}

}
