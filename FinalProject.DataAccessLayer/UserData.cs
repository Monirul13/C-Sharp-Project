using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinalProject;
using System.Data.SqlClient;
using System.Data;
using FinalProject.FrameworkLayer;
using FinalProject.EntityLayer;


namespace FinalProject.DataAccessLayer
{
    public class UserData
    {
        
     //General Function to Access Data;
   
        List<UserInfo> GetData(SqlCommand cmd)
        {

           cmd.Connection.Open();

           List<UserInfo> list = new List<UserInfo>();

            using (SqlDataReader reader =cmd.ExecuteReader())
            {
               


                while (reader.Read())
                {

                    UserInfo userObj = new UserInfo();

                    userObj.Name = reader.GetString(0);
                    userObj.Contact = reader.GetString(1);
                    userObj.Email = reader.GetString(2);
                    userObj.BloodGroup = reader.GetString(3);
                    userObj.Religion = reader.GetString(4);
                    userObj.Gender = reader.GetString(5);
                    userObj.LastDateOfBloodDonatin = reader.GetString(6);
                    userObj.Division = reader.GetString(7);
                    userObj.Area = reader.GetString(8);
                    userObj.PassWord = reader.GetString(9);


                    list.Add(userObj);

                }
                reader.Close();
            }
            cmd.Connection.Close();


            return list;

        }



  //Fuction to get student Information as Student List;

        public List<UserInfo> GetUserList(string str1,string str2)
        {
            SqlDbAccess dbAccess = new SqlDbAccess();

            SqlCommand cmd = dbAccess.GetCommand("SELECT * FROM UserInfo WHERE BloodGroup =@title AND DIvision =@title1");


            SqlParameter param1 = new SqlParameter("@title", SqlDbType.VarChar, 5);
            param1.Value = str1;

            SqlParameter param2 = new SqlParameter("@title1", SqlDbType.VarChar, 20);
            param2.Value = str2;

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

           List<UserInfo> userList = GetData(cmd);

            return userList;
        }


        //function overload

        public List<UserInfo> GetUserList()
        {
            SqlDbAccess dbAccess = new SqlDbAccess();

            SqlCommand cmd = dbAccess.GetCommand("SELECT * FROM UserInfo");


            //SqlParameter param1 = new SqlParameter("@title", SqlDbType.VarChar, 5);
            //param1.Value = str1;

            //SqlParameter param2 = new SqlParameter("@title1", SqlDbType.VarChar, 20);
            //param2.Value = str2;

            //cmd.Parameters.Add(param1);
            //cmd.Parameters.Add(param2);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            List<UserInfo> userList = GetData(cmd);

            return userList;
        }




    //Function to insert userinformation

        public bool Insert(UserInfo userObj)
        {
            SqlDbAccess dbAccessObj = new SqlDbAccess();

            
            
            SqlCommand cmd = dbAccessObj.GetCommand("INSERT INTO UserInfo VALUES(@title1, @title2, @title3, @title4, @title5, @title6, @title7, @title8, @title9, @title10)");
            
            cmd.Connection.Open();

            SqlParameter param1 = new SqlParameter("@title1",SqlDbType.VarChar,20 );
            param1.Value = userObj.Name;

            SqlParameter param2 = new SqlParameter("@title2", SqlDbType.VarChar,50);
            param2.Value = userObj.Contact;

            SqlParameter param3 = new SqlParameter("@title3",SqlDbType.VarChar,50);
            param3.Value = userObj.Email;

            SqlParameter param4 = new SqlParameter("@title4",SqlDbType.VarChar,5);
            param4.Value = userObj.BloodGroup;

            SqlParameter param5 = new SqlParameter("@title5",SqlDbType.VarChar,10);
            param5.Value = userObj.Religion;

            SqlParameter param6 = new SqlParameter("@title6",SqlDbType.VarChar,10);
            param6.Value = userObj.Gender;

            SqlParameter param7 = new SqlParameter("@title7",SqlDbType.VarChar,50);
            param7.Value = userObj.LastDateOfBloodDonatin;

            SqlParameter param8 = new SqlParameter("@title8",SqlDbType.VarChar,20);
            param8.Value = userObj.Division;
            SqlParameter param9 = new SqlParameter("@title9",SqlDbType.VarChar,10);
            param9.Value = userObj.Area;

            SqlParameter param10 = new SqlParameter("@title10",SqlDbType.VarChar,50);
            param10.Value = userObj.PassWord;

            cmd.Parameters.Add(param1);
            cmd.Parameters.Add(param2);
            cmd.Parameters.Add(param3);
            cmd.Parameters.Add(param4);
            cmd.Parameters.Add(param5);
            cmd.Parameters.Add(param6);
            cmd.Parameters.Add(param7);
            cmd.Parameters.Add(param8);
            cmd.Parameters.Add(param9);
            cmd.Parameters.Add(param10);
            
            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();

            return val > 0;


        }

    }
}
