using AdoNetPractice.Models;
using Microsoft.Data.SqlClient;
string connetionString = "Server=MYSTERY;Database=HomePractice;Trusted_Connection=true;TrustServerCertificate=true";
List<County> countries = new();
using (SqlConnection connection = new SqlConnection(connetionString))
{
    connection.Open();
    string sqlQuery = "Select * from Country co\r\njoin city c\r\non co.id=c.CountryId";
    using (SqlCommand command = new(sqlQuery, connection))
    {
        using (SqlDataReader reader = command.ExecuteReader())
        {

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    County county = new County();
                    county.Id = reader.GetInt32(0);
                    county.Name = reader.GetString(1);
                    county.Population = reader.GetDecimal(2);
                    countries.Add(county);
                }
            }
        }
    }
}
foreach (var country in countries)
{
    Console.WriteLine(country);
}