using Shop.Components;

namespace Shop;

public class SystemUnitBuilder
{
    private SystemUnit _systemUnit;

    public SystemUnitBuilder()
    {
        _systemUnit = new SystemUnit();
    }

    public void Reset()
    {
        _systemUnit = new SystemUnit();
    }

    public void SetBox(Box box)
    {
        _systemUnit.Box = box;
    }

    public void SetHdd(Hdd hdd)
    {
        _systemUnit.Hdd = hdd;
    }

    public void SetMainBoard(MainBoard mainBoard)
    {
        _systemUnit.MainBoard = mainBoard;
    }

    public void SetMemory(Memory memory)
    {
        _systemUnit.Memory = memory;
    }

    public void SetProcessor(Processor processor)
    {
        _systemUnit.Processor = processor;
    }


    public SystemUnit GetSystemUnit()
    {
        return _systemUnit;
    }
}
