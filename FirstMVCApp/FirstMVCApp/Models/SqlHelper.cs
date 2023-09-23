using Microsoft.Data.SqlClient;

namespace FirstMVCApp.Models
{ 

    public class SqlHelper
    {
        public static SqlConnection CreateConnection()
    {
        var conString = @"server=200411LTP2869\SQLEXPRESS;database=vishnu;
                        integrated security=true;Encrypt=false;";
        SqlConnection sqlcn=new SqlConnection(conString);
        return sqlcn;
    }
    }
}
