using static IPhone;

IFactory factory = new AppleFactory(IPhone.DeviceModel.Iphone14Pro);


CreateAndCall(factory);


static void CreateAndCall(IFactory factory)
{
    var phone = factory.CreateSmartphone();

    phone.Call();
}

public interface ISmartphone
{
    void Call();
}

public interface IFactory
{
    ISmartphone CreateSmartphone(); // Factory Method
}


public class IPhone : ISmartphone
    {
        public enum DeviceModel
        {
            Iphone11, Iphone11Pro, Iphone14Pro
        }

        public string SerialNumber { get; }

        public DeviceModel Model { get; }

        public IPhone(string serialNumber, DeviceModel model)
        {
            SerialNumber = serialNumber;
            Model = model;
        }

        public void Call()
        {
            Console.WriteLine($"Calling from {Model.ToString()}. SerialNumber {SerialNumber}");
        }
    }
    public class SimplePhone : ISmartphone
    {
        public void Call()
        {
            Console.WriteLine("Calling from simple phone");
        }
    }

    public class AppleFactory : IFactory
    {
        public IPhone.DeviceModel CurrentModel { get; }

        public AppleFactory(IPhone.DeviceModel currentModel)
        {
            CurrentModel = currentModel;
        }

        public ISmartphone CreateSmartphone()
        {
            return new IPhone(Random.Shared.Next().ToString(), CurrentModel);
        }
    }
    public class SimplePhoneFactory : IFactory
    {
        public ISmartphone CreateSmartphone()
        {
            return new SimplePhone();
        }
    }