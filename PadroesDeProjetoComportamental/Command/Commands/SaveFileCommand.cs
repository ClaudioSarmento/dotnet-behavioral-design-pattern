using Command.Interface;

namespace Command.Commands;

public class SaveFileCommand : ICommand
{
    private Receiver _receiver;

    public SaveFileCommand(Receiver receiver)
    {
        _receiver = receiver; 
    }

    public void Execute()
    {
        _receiver.SaveFile();
    }
}
