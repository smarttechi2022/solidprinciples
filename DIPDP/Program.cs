namespace DIPDP
{
    public interface IRepositoryLayer
    {
        void SaveData(int Id);
    }

    public class BusinessLogicLayer 
    {
        private readonly IRepositoryLayer _iRepositoryLayer;
        public BusinessLogicLayer(IRepositoryLayer iRepositoryLayer)
        {
            _iRepositoryLayer = iRepositoryLayer;
        }

        public void SaveData(int Id)
        {
            _iRepositoryLayer.SaveData(Id);
        }

    }

    public class DataAccessLayer: IRepositoryLayer
    {
        public void SaveData(int Id)
        {
            //Save Data
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}