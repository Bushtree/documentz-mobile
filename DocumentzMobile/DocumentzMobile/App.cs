using DocumentzMobile.Helpers;
using DocumentzMobile.Interfaces;
using DocumentzMobile.Services;
using DocumentzMobile.Model;

namespace DocumentzMobile
{
    public partial class App
    {
        public App()
        {
        }

        public static void Initialize()
        {
            ServiceLocator.Instance.Register<IDataStore<Item>, MockDataStore>();
        }
    }
}