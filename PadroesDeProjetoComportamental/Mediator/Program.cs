using System.Reflection.Metadata;

public interface IChatRoom
{
    void Register(User user);
    void Send(string message, User user);
}

public class ChatRoom : IChatRoom
{
    private List<User> _users = new List<User>();

    public void Register(User user)
    {
        _users.Add(user); 
    }

    public void Send(string message, User sender)
    {
        foreach(User user in _users)
        {
            if(user != sender)
            {
                user.Receive(message);
            }
        }
    }
}

public abstract class User
{
    protected IChatRoom _chatRoom;

    public User(IChatRoom chatRoom)
    {
        _chatRoom = chatRoom;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);

}

public class ChatUser : User
{
    public ChatUser(IChatRoom chatRoom) : base(chatRoom) { }

    public override void Send(string message)
    {
        Console.WriteLine(message);
        _chatRoom.Send(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine("User receives message: " + message);
       
    }
}

class Program
{
    static void Main(string[] args)
    {
        IChatRoom chatRoom = new ChatRoom();

        User user1 = new ChatUser(chatRoom);
        User user2 = new ChatUser(chatRoom);   
        User user3 = new ChatUser(chatRoom);

        chatRoom.Register(user1);
        chatRoom.Register(user2);
        chatRoom.Register(user3);

        user1.Send("Hello, world!");
        user2.Send("Hi there!");
    }
}