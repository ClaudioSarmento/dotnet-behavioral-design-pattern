using Command.Interface;

namespace Command.Commands;

public class OpenFileCommand : ICommand
{
    private Receiver _receiver;
    
    public OpenFileCommand(Receiver receiver)
    {
        _receiver = receiver; 
    }

    public void Execute()
    {
        _receiver.OpenFile();
    }
}
