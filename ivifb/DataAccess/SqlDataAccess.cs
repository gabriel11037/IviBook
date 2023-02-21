using System.Configuration;

namespace FreeBook
{
class SqlDataAccess
{
        public static string GetCartiStrings()
        {
            return ConfigurationManager.AppSettings["carti"];
        }

        public static string GetImprumuturiStrings()
        {
            return ConfigurationManager.AppSettings["imprumuturi"];
        }

        public static string GetUtilizatoriStrings()
        {
            return ConfigurationManager.AppSettings["utilizatori"];
        }

        public static string GetConnectionStrings()
        {
            return ConfigurationManager.ConnectionStrings[""].ConnectionString;
        }

    }
}
