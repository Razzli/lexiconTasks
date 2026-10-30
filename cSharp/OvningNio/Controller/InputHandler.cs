namespace OvningNio.Controller;

class InputHandler : IStringInputHandler, IIntInputHandler
{
    string IStringInputHandler.Read()
    {
        throw new NotImplementedException();
    }

    int IIntInputHandler.Read()
    {
        throw new NotImplementedException();
    }
}