using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.Data.SqlClient;
using System.Data;

namespace FirstMVCApp.Models
{
    public class EmpClassRepository
    {
        public static List<Employee> GetEmplist()
        {
            List<Employee> employees = new List<Employee>();
            using (SqlConnection cn =  SqlHelper.CreateConnection())
            {
                if(cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand sqlCommand = cn.CreateCommand();   
                string selectAllEmps = "Select * From emptbl_x";
                sqlCommand.CommandText = selectAllEmps;
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {

                    Employee emp = new Employee();

                    emp.eno = sqlDataReader.GetInt32(0);

                    emp.name = sqlDataReader.GetString(1);

                    emp.salary = sqlDataReader.GetDecimal(2);

                    emp.city = sqlDataReader.GetString(3);

                    employees.Add(emp);

                }

                

            }

            return employees;
        }
        public static Employee GetEmpbyId(int id)
        {

            Employee empFound = new Employee();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != System.Data.ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectempcmd = cn.CreateCommand();
                string selectEmps = "Select * from emptbl_x where eno=@id";
                selectempcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectempcmd.CommandText = selectEmps;
                SqlDataReader empdr = selectempcmd.ExecuteReader();
                while (empdr.Read())
                {

                    empFound.eno = empdr.GetInt32(0);
                    empFound.name = empdr.GetString(1);
                    empFound.salary = empdr.GetDecimal(2);
                    empFound.city = empdr.GetString(3);
                    
                    
                }
            }
            return empFound;
           
        }
        public static int AddNewEmp(Employee employee) 
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertEmpcmd = cn.CreateCommand();
                String insertNewEmpQuery = "insert into emptbl_x values( @id,@name,@salary,@city )";
                insertEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = employee.eno;
                insertEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = employee.name;
                insertEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = employee.city;
                insertEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = employee.salary;
                insertEmpcmd.CommandText = insertNewEmpQuery;
                query_result = insertEmpcmd.ExecuteNonQuery();
            }
            return query_result;
            
        }



        public static int UpdateEmp(Employee modifiedEmp)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateEmpcmd = cn.CreateCommand();
                String updateEmpQuery = "Update emptbl_x set name=@name, salary=@salary, city=@city where eno=@id";
                updateEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedEmp.eno;
                updateEmpcmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = modifiedEmp.name;
                updateEmpcmd.Parameters.Add("@city", SqlDbType.NVarChar).Value = modifiedEmp.city;
                updateEmpcmd.Parameters.Add("@salary", SqlDbType.Decimal).Value = modifiedEmp.salary;
                updateEmpcmd.CommandText = updateEmpQuery;
                query_result = updateEmpcmd.ExecuteNonQuery();
            }
            return query_result;
        }



        public static int DeleteEmp(int id) 
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteEmpcmd = cn.CreateCommand();
                String deleteEmpQuery = "Delete from emptbl_x where eno=@id";
                deleteEmpcmd.Parameters.Add("@id", SqlDbType.Int).Value =id;
                deleteEmpcmd.CommandText = deleteEmpQuery;
                query_result = deleteEmpcmd.ExecuteNonQuery();
            }
            return query_result;
           
        }
    }
}
