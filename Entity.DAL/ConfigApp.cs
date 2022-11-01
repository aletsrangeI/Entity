namespace Entity.DAL
{
    public class ConfigApp
    {
        public string NombreBd;
        public string Host;
        public string UserBd;
        public string PassBd;
        public string CadenaConexion;

        public bool Produccion = false;
        public ConfigApp()
        {
            if (Produccion)
            {
                
            }
            else
            {
                NombreBd = "Test";
                Host = "DESKTOP-5H0J46U";
                UserBd = "alexr";
                PassBd = "12345";
            }

            //CadenaConexion = "Data Source=" + Host + "; Initial Catalog=" + NombreBd + "; User ID=" + UserBd + "; Password=" + PassBd + "; Enlist=False; Min Pool Size=1; Max Pool Size=300; Connect Timeout=300; User Instance=False";
              CadenaConexion = "data source=localhost; initial catalog = test; persist security info = True; Integrated Security = SSPI; ";
        }
    }
}