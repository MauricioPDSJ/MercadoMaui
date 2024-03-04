using MercadoMaui.Helpers;

namespace MercadoMaui
{
    public partial class App : Application
    {
        static SQLiteDataBaseHelper _db;

        public static SQLiteDataBaseHelper Db
        {
            get
            {
                if (_db == null)
                {
                    string path = Path.Combine(
                        Environment.GetFolderPath(
                            Environment.SpecialFolder.LocalApplicationData
                        ), "banco_sqlite_compras.db3"

                    );

                    _db = new SQLiteDataBaseHelper( path );
                
                }// Fecha if verificando se _db é null
                
                return _db;
            }//Fecha metodo get
        }
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
