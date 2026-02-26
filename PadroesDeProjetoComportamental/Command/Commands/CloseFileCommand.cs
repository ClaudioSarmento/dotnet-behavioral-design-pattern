using Command.Interface;

namespace Command.Commands;

public class CloseFileCommand : ICommand
{
    private Receiver _receiver;

    public CloseFileCommand(Receiver receiver)
    {
        _receiver = receiver; 
    }

    public void Execute()
    {
        _receiver.CloseFile();    
    }
}
