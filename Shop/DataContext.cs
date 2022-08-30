using Shop.Components;

namespace Shop;

public class DataContext
{
    public List<Box> Boxes => new()
    {
        new Box()
        {
            Name = "Box RZTK PcCooler Master RP300 Mesh ARGB 4F",
            CoolersNumber = 4,
            Price = 2429
        },
        new Box()
        {
            Name = "Box Razer Tomahawk ATX (RC21-01420100-R3M1)",
            CoolersNumber = 1,
            Price = 8099
        },
        new Box()
        {
            Name = "Box Lian Li Lancool ONE Digital Black (G99.LANONE-D.X0)",
            CoolersNumber = 1,
            Price = 3569
        },
        new Box()
        {
            Name = "Box DarkFlash Aquarius Mesh Black",
            CoolersNumber = 4,
            Price = 1599
        },
    };

    public List<Processor> Processors => new()
    {
        new Processor()
        {
            Name = "Processor Intel Core i5-10400F",
            CoresNumber = 6,
            Price = 4459
        },
        new Processor()
        {
            Name = "Processor Intel Core i9-12900K",
            CoresNumber = 16,
            Price = 23001
        },
        new Processor()
        {
            Name = "Processor AMD Ryzen 9 5950X",
            CoresNumber = 16,
            Price = 21120
        },
        new Processor()
        {
            Name = "Processor AMD Ryzen 7 5800X",
            CoresNumber = 8,
            Price = 12704
        },
    };

    public List<MainBoard> MainBoards => new()
    {
        new MainBoard()
        {
            Name = "Motherboard Asus Prime H510M-A",
            MaxFrequency = 3200,
            Price = 2349
        },
        new MainBoard()
        {
            Name = "Motherboard Asus Prime B560-Plus",
            MaxFrequency = 4600,
            Price = 4399
        },
        new MainBoard()
        {
            Name = "Motherboard MSI MAG X570S Torpedo MAX",
            MaxFrequency = 3200,
            Price = 7028
        },
        new MainBoard()
        {
            Name = "Motherboard MSI B450 Tomahawk Max II",
            MaxFrequency = 3000,
            Price = 2955
        },
    };

    public List<Memory> Memories => new()
    {
        new Memory()
        {
            Name = "Memory Kingston Fury DDR4-3200 16384MB PC4-25600 (Kit of 2x8192) Beast Black (KF432C16BBK2/16)",
            MemoryType = "DDR4 SDRAM",
            Price = 2689
        },
        new Memory()
        {
            Name = "Memory Kingston Fury DDR5-6000 32768MB PC5-48000 (Kit of 2x16384) Beast Black (KF560C40BBK2-32)",
            MemoryType = "DDR5 SDRAM",
            Price = 12338
        },
        new Memory()
        {
            Name = "Memory Crucial DDR4-3200 8192MB PC4-25600 Ballistix Black (BL8G32C16U4B)",
            MemoryType = "DDR4 SDRAM",
            Price = 1272
        },
        new Memory()
        {
            Name = "Memory DDR4 SDRAM",
            MemoryType = "DDR4 SDRAM",
            Price = 4599
        },
    };

    public List<Hdd> Hdds => new()
    {
        new Hdd()
        {
            Name = "HDD Toshiba Enterprise Performance 1.2TB 10500rpm 128MB AL15SEB120N 2.5 SAS",
            Volume = 1.2f,
            Price = 6219
        },
        new Hdd()
        {
            Name = "Seagate IronWolf HDD 4TB 5900rpm 64MB ST4000VN008 3.5 SATAIII",
            Volume = 4,
            Price = 3389
        },
        new Hdd()
        {
            Name = "Seagate BarraCuda HDD 1TB 7200rpm 64MB ST1000DM010 3.5 SATA III",
            Volume = 1,
            Price = 1269
        },
        new Hdd()
        {
            Name = "HDD Western Digital Blue 1TB 7200rpm 64MB WD10EZEX 3.5 SATA III",
            Volume = 1,
            Price = 1409
        },
    };
}
